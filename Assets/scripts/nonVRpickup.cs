using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonVRpickup : MonoBehaviour {
	public buttons buttons;
	bool touching;
	bool holding;
	Transform camera;
	Transform offset;
	Transform origTransform;
	// Use this for initialization
	void Start () {
		touching = false;
		camera = transform.GetChild(0);
		offset = camera.GetChild(0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		touching = true;
	}

	void onTriggerStay(Collider col){
		Debug.Log("in range");
		if(buttons.trigger){
			holding = true;
		}else{
			holding = false;
		}

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

	void onTriggerExit(Collider col){
		touching = false;
	}
}
