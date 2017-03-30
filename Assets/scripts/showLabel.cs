using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLabel : MonoBehaviour {
	public GameObject label;
	// Use this for initialization
	void Awake () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void show(){
		GetComponent<MeshRenderer>().enabled = true;
		label.SetActive(true);
	}
	public void hide(){
		GetComponent<MeshRenderer>().enabled = false;
		label.SetActive(false);
	}
}
