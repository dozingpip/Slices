
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class FloatEvent : UnityEvent<float>{}

public class controller_stuff : MonoBehaviour {
	public SteamVR_TrackedObject left, right;
	//public GameObject head;
	public FloatEvent totalDist, distHead, vive_scroll;
	//float distLC, distRC;
	SteamVR_Controller.Device rightD, leftD;
	public UnityEvent vive_grip, vive_menu, vive_triggerup, vive_trigger, vive_leftMenu, vive_rightMenu;
	Vector2 axisR, axisL;
	Vector3 rightPos, leftPos;

	Vector2 touchAxis(SteamVR_Controller.Device device){
		//Check if the device is valid
	    if(device.index == -1){return Vector2.zero;}

		//Get the x,y position on the pad
	    Vector2 touch = device.GetAxis(Valve.VR.EVRButtonId.k_EButton_Axis0);
	    return touch;
	}

	void Awake(){
		left = left.GetComponent<SteamVR_TrackedObject>();
		right = right.GetComponent<SteamVR_TrackedObject>();
	}

	void Update(){
	    
	    rightD = SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Rightmost));
    	leftD = SteamVR_Controller.Input(SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.Leftmost));

		if(rightD.GetTouchUp(SteamVR_Controller.ButtonMask.Grip) || leftD.GetTouchUp(SteamVR_Controller.ButtonMask.Grip))
			vive_grip.Invoke();
		if(rightD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu) || leftD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu))
			vive_menu.Invoke();
		if(leftD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu))
			vive_leftMenu.Invoke();
		if(rightD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu))
			vive_rightMenu.Invoke();
		if(rightD.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger) || leftD.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger))
			vive_triggerup.Invoke();
		if(rightD.GetTouch(SteamVR_Controller.ButtonMask.Trigger) || leftD.GetTouch(SteamVR_Controller.ButtonMask.Trigger))
			vive_trigger.Invoke();

		axisR = touchAxis(rightD);
		axisL = touchAxis(leftD);

		/*if(distRC <= distLC)
			distHead = distRC;
		else
			distHead = distLC;
		*/
		if(Mathf.Abs(axisR[1]) > Mathf.Abs(axisL[1]))
			vive_scroll.Invoke(axisR[1]);
		else
			vive_scroll.Invoke(axisL[1]);
	 }
	
	// Update is called once per frame
	void FixedUpdate () {
		rightPos = right.gameObject.transform.position;
	    leftPos = left.gameObject.transform.position;
	    //distRC = Vector3.Distance(head.transform.position, rightPos);
		//distLC = Vector3.Distance(head.transform.position, leftPos);
	    totalDist.Invoke(Vector3.Distance(leftPos, rightPos));
	}
}