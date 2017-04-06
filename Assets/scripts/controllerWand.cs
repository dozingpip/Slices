using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controllerWand : MonoBehaviour {
	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;
	LineRenderer line;
	public merge_body body;

	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		device = SteamVR_Controller.Input((int)trackedObj.index);
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider col) {
		if(col.gameObject.tag.Contains("button")){
			col.gameObject.GetComponent<uiButtonPress>().hover();
		}

		if(device.GetTouch(SteamVR_Controller.ButtonMask.Trigger) && col.gameObject.tag.Contains("button")){
			col.gameObject.GetComponent<uiButtonPress>().press();
			Debug.Log("name " +col.gameObject.name);
			body.teleportTo(col.gameObject.name);
		}else if(device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger) && col.gameObject.tag.Contains("button")){
			col.gameObject.GetComponent<uiButtonPress>().unPress();
		}
	}
}
