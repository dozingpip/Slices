
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_stuff : MonoBehaviour {
	public SteamVR_TrackedObject left;
	public SteamVR_TrackedObject right;
	//public GameObject head;
	//public Vector3 distanceC;
	public float totalDist;
	//float distLC;
	//float distRC;
	public GameObject cube;
	public GameObject selected;
	Vector3 minSize;
	MeshRenderer meshRendererFlag;
	public bool sizeLocked = false;
	float minHeight;
	public string tag;
	SteamVR_Controller.Device rightD;
	SteamVR_Controller.Device leftD;
	public bool grip = false;
	Vector2 axisR, axisL;
	Vector3 rightPos, leftPos;
	public float scroll;
	public bool menu;

	// Use this for initialization
	void Start () {
		meshRendererFlag = cube.GetComponent<MeshRenderer>();
		selected = cube;
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
	    
	    rightD = SteamVR_Controller.Input((int)right.index);
    	leftD = SteamVR_Controller.Input((int)left.index);

		grip = rightD.GetTouchUp(SteamVR_Controller.ButtonMask.Grip) || leftD.GetTouchUp(SteamVR_Controller.ButtonMask.Grip);
		axisR = touchAxis(rightD);
		axisL = touchAxis(leftD);
		menu = rightD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu) || leftD.GetPressUp(SteamVR_Controller.ButtonMask.ApplicationMenu);

		if(Mathf.Abs(axisR[1]) > Mathf.Abs(axisL[1]))
			scroll = axisR[1];
		else
			scroll = axisL[1];
	 }
	
	// Update is called once per frame
	void FixedUpdate () {
		rightPos = right.gameObject.transform.position;
	    leftPos = left.gameObject.transform.position;
		Rigidbody rb = selected.GetComponent<Rigidbody>();
		if(grip && sizeLocked){
			transform.parent = null;
			selected.tag = "sizeable";
			rb.useGravity = false;
			selected.transform.position = new Vector3(selected.transform.position.x, 1.0f, selected.transform.position.z);
			sizeLocked = false;
		}else if(grip && !sizeLocked){
			rb.gameObject.tag = "pickable";
			rb.useGravity = true;
			sizeLocked = true;
		}

		if(!sizeLocked){
			//distanceC  = leftPos - rightPos;
			//distanceC = new Vector3(Mathf.Abs(distanceC.x), Mathf.Abs(distanceC.y), Mathf.Abs(distanceC.z));
			//distRC = Vector3.Distance(head.transform.position, rightPos);
			//distLC = Vector3.Distance(head.transform.position, leftPos);
			totalDist = Vector3.Distance(leftPos, rightPos);
			selected.transform.localScale = new Vector3(totalDist *3.0F, totalDist *3.0F, totalDist *3.0F);
			if(totalDist> 0.3){
				meshRendererFlag.material.color = Color.green;
			}else{
				meshRendererFlag.material.color = Color.red;
			}
		}
	}
}