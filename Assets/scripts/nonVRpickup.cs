using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class nonVRpickup : MonoBehaviour {
	bool holding;
	Transform camera;
	Transform offset;
	Transform origTransform;
	UnityEvent trigger, triggerUp, canTeleport;
	// Use this for initialization
	void Start () {
		camera = transform.GetChild(0);
		offset = camera.GetChild(0);
		trigger.AddListener(trig);
		triggerUp.AddListener(trigUp);
	}

	void onTriggerStay(Collider col){
		Debug.Log("in range");
		canTeleport.Invoke();
		if(holding){
			origTransform = col.gameObject.transform;
			col.gameObject.transform.position = offset.position;
			col.gameObject.transform.rotation = offset.rotation;
			col.gameObject.transform.SetParent(camera);
		}else{
			col.gameObject.transform.position = origTransform.position;
			col.gameObject.transform.rotation = origTransform.rotation;
		}
	}

	void trig(){
		holding = true;
	}

	void trigUp(){
		holding = false;
	}
}
