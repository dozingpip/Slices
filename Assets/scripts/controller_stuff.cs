
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_stuff : MonoBehaviour {
	public GameObject head;
	public Vector3 distanceC;
	public float totalDist;
	float distLC;
	float distRC;
	public GameObject cube;
	public GameObject selected;
	Vector3 minSize;
	MeshRenderer meshRendererFlag;
	public float rotationSpeed = 1.0f;
	public bool sizeLocked = false;
	float minHeight;
	public string tag;
	SteamVR_Controller.Device right;
	SteamVR_Controller.Device left;
	public bool grip = false;
	Vector2 axisd1, axisd2;
	public bool swipeUp;
	public bool swipeDown;

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

	//Physics stuff here:
	void FixedUpdate(){
	    right = SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.FarthestRight);
	    left = SteamVR_Controller.GetDeviceIndex(SteamVR_Controller.DeviceRelation.FarthestLeft);
	    right = SteamVR_Controller.Input(right.index);
	    left = SteamVR_Controller.Input(left.index);

		grip = rightDevice.GetTouchUp(SteamVR_Controller.ButtonMask.Grip) || leftDevice.GetTouchUp(SteamVR_Controller.ButtonMask.Grip);
		axisR = touchAxis(rightDevice);
		axisL = touchAxis(leftDevice);

		//Debug.Log(axisd1 + ", " + axisd2);
		if(axisR[1] > 0.5f || axisL[1] > 0.5f){
			swipeUp = true;
			swipeDown = false;
		}else if(axisR[1] > -0.5f || axisL[1] > -0.5f){
			swipeUp = false;
			swipeDown = true;
		}else{
			swipeUp = false;
			swipeDown = false;
		}
	 }
	
	// Update is called once per frame
	void Update () {
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

		//rotator.transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime);

		if(!sizeLocked){
			distanceC  = left.transform.position - right.transform.position;
			distanceC = new Vector3(Mathf.Abs(distanceC.x), Mathf.Abs(distanceC.y), Mathf.Abs(distanceC.z));
			distRC = Vector3.Distance(head.transform.position, right.gameObject.transform.position);
			distLC = Vector3.Distance(head.transform.position, left.gameObject.transform.position);
			totalDist = Vector3.Distance(left.gameObject.transform.position, right.gameObject.transform.position);
			selected.transform.localScale = new Vector3(totalDist *3.0F, totalDist *3.0F, totalDist *3.0F);
			if(totalDist> 0.3){
				meshRendererFlag.material.color = Color.green;
			}else{
				meshRendererFlag.material.color = Color.red;
			}
		}
	}
}