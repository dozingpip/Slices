
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_stuff : MonoBehaviour {
	public SteamVR_TrackedObject left;
	public SteamVR_TrackedObject right;
	public SteamVR_TrackedObject head;
	Vector3 distanceC;
	float totalDist;
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
	SteamVR_Controller.Device device1;
	SteamVR_Controller.Device device2;
	bool grip = false;

	// Use this for initialization
	void Start () {
		meshRendererFlag = cube.GetComponent<MeshRenderer>();
		selected = cube;
	}

	void Awake () {
		
	}

	//Physics stuff here:
	void FixedUpdate(){
		device1 = SteamVR_Controller.Input((int)left.index);
		device2 = SteamVR_Controller.Input((int)right.index);
		grip = device1.GetTouchUp(SteamVR_Controller.ButtonMask.Grip) || device2.GetTouchUp(SteamVR_Controller.ButtonMask.Grip);
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
			distRC = Vector3.Distance(head.transform.position, right.transform.position);
			distLC = Vector3.Distance(head.transform.position, left.transform.position);
			totalDist = Vector3.Distance(left.transform.position, right.transform.position);
			//if((distanceC *2.0F).x > minSize.x && (distanceC *3.0F).y > minSize.y && (distanceC *3.0F).z > minSize.z){
				selected.transform.localScale = distanceC *3.0F;
			//}
			if(totalDist> 0.3){
				meshRendererFlag.material.color = Color.green;
			}else{
				meshRendererFlag.material.color = Color.red;
			}
		}
	}
}