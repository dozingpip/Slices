using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controllerWand : MonoBehaviour {
	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;
	LineRenderer line;

	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		device = SteamVR_Controller.Input((int)trackedObj.index);
	}

	void OnTriggerEnter(Collider col){
		if(col.gameObject.tag.Contains("button"))
			col.gameObject.GetComponent<uiButtonPress>().hover();
	}
	
	// Update is called once per frame
	void OnTriggerStay(Collider col) {
		if(col.gameObject.tag.Contains("button") && device.GetTouch(SteamVR_Controller.ButtonMask.Trigger)){
			col.gameObject.GetComponent<uiButtonPress>().press();
			Debug.Log("teleporting to " + col.gameObject.name);
		}else if(col.gameObject.tag.Contains("button") && device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger)){
			col.gameObject.GetComponent<uiButtonPress>().unPress();
		}
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.tag.Contains("button"))
			col.gameObject.GetComponent<uiButtonPress>().notHover();
	}
}
