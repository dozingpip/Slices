using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiButtonPress : MonoBehaviour {
	public merge_body body;
	public Button btn;
	showHide showhide;	// Use this for initialization
	void Start () {
		btn = GetComponent<Button>();
		// gameobject container is 5 levels up
		showhide = transform.parent.parent.parent.parent.parent.GetComponent<showHide>();
	}

	public void hover(){
		btn.Select();
	}

	public void notHover(){
		GameObject myEventSystem = GameObject.Find("EventSystem");
		myEventSystem .GetComponent<UnityEngine.EventSystems.EventSystem>().SetSelectedGameObject(null);
	}

	public void press(){
		body.block();
		Debug.Log(name+ " button was pressed");
		body.select(name);
		body.teleportTo(name);
		showhide.hideList();
		notHover();
	}
}
