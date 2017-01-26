﻿using UnityEngine;
using System.Collections;

public class buttons : MonoBehaviour {
	public toggle_vr vr;
	public GameObject leftC;
	public GameObject rightC;
	SteamVR_TrackedController left;
	SteamVR_TrackedController right;
	// Use this for initialization
	void Start () {
		vr = GetComponent<toggle_vr>();
		left = leftC.GetComponent<SteamVR_TrackedController>();
		right = rightC.GetComponent<SteamVR_TrackedController>();
	}

	// Update is called once per frame
	void Update () {
		
	}
	
	public string checkButtons(){
		if (vr.on) {
			/*if (left.triggerPressed || right.triggerPressed) {
				return "Flashlight";
			} else {
				return null;
			}*/
			return null;
		}else{
			if (Input.GetKeyDown (KeyCode.E)) {
				return "Pickup";
			} else if (Input.GetKeyDown (KeyCode.F)) {
				return "Flashlight";
			} else if(Input.GetKey("q")){
				Application.Quit();
				return null;
			}else {
				return null;
			}
		}
	}
}