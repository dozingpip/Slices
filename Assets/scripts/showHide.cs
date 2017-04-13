using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHide : MonoBehaviour {
	public controller_stuff controller;
	public bool shown = false;
	GameObject ui;
	// Use this for initialization
	void Start () {
		ui = transform.Find("main ui").gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(controller.leftMenu && !shown){
			show();
		}else if(controller.leftMenu && shown){
			hide();
		}
	}

	public void show(){
		shown = true;
		ui.SetActive(true);
	}

	public void hide(){
		shown = false;
		ui.SetActive(false);
	}
}
