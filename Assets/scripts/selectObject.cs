using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectObject : MonoBehaviour {
	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;
	public controller_stuff sendTo;

	// Use this for initialization
	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}

	void Start (){
	}

	void FixedUpdate(){
		device = SteamVR_Controller.Input((int)trackedObj.index);
	}

	void OnTriggerStay (Collider col) {
		if(device.GetTouchUp(SteamVR_Controller.ButtonMask.ApplicationMenu)){
			if(col.gameObject.tag.Contains("pickable")){
				sendTo.selected = col.gameObject;
				sendTo.tag = col.tag;
				col.gameObject.tag = "sizeable";
				sendTo.sizeLocked = false;
			}
		}
	}
}
