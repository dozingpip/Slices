using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller_scaler : MonoBehaviour {
	public controller_stuff controller;
	public GameObject selected;
	Vector3 minSize;
	public bool sizeLocked = false;
	float minHeight;
	public string tag;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Rigidbody rb = selected.GetComponent<Rigidbody>();
		if(controller.grip && sizeLocked){
			transform.parent = null;
			selected.tag = "sizeable";
			rb.useGravity = false;
			selected.transform.position = new Vector3(selected.transform.position.x, 1.0f, selected.transform.position.z);
			sizeLocked = false;
		}else if(controller.grip && !sizeLocked){
			rb.gameObject.tag = "pickable";
			rb.useGravity = true;
			sizeLocked = true;
		}

		if(!sizeLocked){
			selected.transform.localScale = new Vector3(controller.totalDist *3.0F, controller.totalDist *3.0F, controller.totalDist *3.0F);
			/*if(totalDist> 0.3){
				meshRendererFlag.material.color = Color.green;
			}else{
				meshRendererFlag.material.color = Color.red;
			}*/
		}
	}
}
