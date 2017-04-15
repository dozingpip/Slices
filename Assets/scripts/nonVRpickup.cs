using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonVRpickup : MonoBehaviour {
	public buttons buttons;
	bool touching;
	bool holding;
	// Use this for initialization
	void Start () {
		touching = false;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){
		touching = true;
	}

	void onTriggerStay(Collider col){
		if(buttons.trigger){
			holding = true;
		}else{
			holding = false;
		}

		if(holding){
			Debug.Log("boop");
		}
	}

	void onTriggerExit(Collider col){
		touching = false;
	}
}
