using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showLabel : MonoBehaviour {
	public GameObject label;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void show(){
		label.SetActive(true);
	}
	public void hide(){
		label.SetActive(false);
	}
}
