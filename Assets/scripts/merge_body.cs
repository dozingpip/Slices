using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merge_body : MonoBehaviour {
	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;
	float timeToHold = 2.0f;
	public float timeHeld;
	public float breakforce = 1000.0f;
	FixedJoint fixedJoint;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider col){
		timeHeld = 0.1f;
		//Debug.Log("triggered");
	}

	void OnTriggerStay(Collider col){
		if(col.gameObject.tag.Contains("pickable")  && col.gameObject.transform.position.y < transform.position.y && timeHeld>0){
			fixedJoint = col.gameObject.GetComponent<FixedJoint>();
			if(timeHeld >= timeToHold){
				//Debug.Log("held for long enough");
				if(fixedJoint==null){
					fixedJoint = col.gameObject.AddComponent<FixedJoint>();
					//Debug.Log("added joint");
				}
				fixedJoint.connectedBody = GetComponent<Rigidbody>();
				//Debug.Log("connected joint");
				//fixedJoint.breakForce = breakforce;
			}else{
				//Debug.Log("time at " + timeHeld);
				timeHeld += Time.deltaTime;
			}
		}else if(timeHeld<=0){
			fixedJoint = null;
		}
	}

	void OnTriggerExit(Collider col){
		timeHeld = 0.0f;
		//Debug.Log("exit");
	}
}