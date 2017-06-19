using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class controllerWand : MonoBehaviour {
	PFixedJoint device;

	void Start () {
		device = transform.parent.GetComponent<PFixedJoint>();
	}

	void OnTriggerStay(Collider col){
		if(col.gameObject.tag.Contains("button")){
			Debug.Log(col.transform.parent.gameObject.name);
			col.transform.parent.gameObject.GetComponent<uiButtonPress>().hover();
			if(device.trigger){
				col.transform.parent.gameObject.GetComponent<uiButtonPress>().press();
			}
		}
	}

	void OnTriggerExit(Collider col){
		if(col.gameObject.tag.Contains("button"))
			col.transform.parent.gameObject.GetComponent<uiButtonPress>().notHover();
	}
}
