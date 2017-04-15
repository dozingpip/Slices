using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiButtonPress : MonoBehaviour {
	public merge_body body;
	public Color hoverColor;
	showHide showhide;
	Color origColor;
	// Use this for initialization
	void Start () {
		origColor = GetComponent<Button>().colors.normalColor;
		// gameobject container is 5 levels up
		showhide = transform.parent.parent.parent.parent.parent.GetComponent<showHide>();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void hover(){
		changeColor(hoverColor);
	}

	public void notHover(){
		changeColor(origColor);
	}

	public void press(){
		Debug.Log(name + " button pressed ");
		body.teleportTo(name);
		showhide.hideList();
		notHover();
	}

	public void unPress(){

	}

	void changeColor(Color newColor){
		ColorBlock colors = GetComponent<Button>().colors;
		colors.normalColor = newColor;
		GetComponent<Button>().colors = colors;
	}
}
