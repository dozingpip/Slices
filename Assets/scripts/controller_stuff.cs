
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_stuff : MonoBehaviour {
	public SteamVR_TrackedObject left, right;
	//public GameObject head;
	public float totalDist, distHead, scroll;
	//float distLC, distRC;
	SteamVR_Controller.Device rightD, leftD;
	public bool grip, menu, touching, trigger, leftMenu, rightMenu;
	Vector2 axisR, axisL;
	public Vector3 rightPos, leftPos;

	// Use this for initialization
	void Start () {
	}

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

		grip = rightD.GetTouchUp(SteamVR_Controller.ButtonMask.Grip) || leftD.GetTouchUp(SteamVR_Controller.ButtonMask.Grip);
		axisR = touchAxis(rightD);
		axisL = touchAxis(leftD);
		menu = rightD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu) || leftD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu);
		leftMenu = leftD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu);
		rightMenu = rightD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu);

		trigger = rightD.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger) || leftD.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger);
		/*if(distRC <= distLC)
			distHead = distRC;
		else
			distHead = distLC;
		*/
		if(Mathf.Abs(axisR[1]) > Mathf.Abs(axisL[1]))
			scroll = axisR[1];
		else
			scroll = axisL[1];
	 }
	
	// Update is called once per frame
	void FixedUpdate () {
		rightPos = right.gameObject.transform.position;
	    leftPos = left.gameObject.transform.position;
	    //distRC = Vector3.Distance(head.transform.position, rightPos);
		//distLC = Vector3.Distance(head.transform.position, leftPos);
	    totalDist = Vector3.Distance(leftPos, rightPos);
	}
}