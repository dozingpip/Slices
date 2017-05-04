using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class controller_scaler : MonoBehaviour {
	public GameObject selected;
	Vector3 minSize;
	public bool sizeLocked = false;
	float minHeight;
	UnityEvent grip;
	FloatEvent totalDist;
	//public string tag;
	
	void Start(){
		grip.AddPersistentListener(reSize);
		totalDist.AddPersistentListener(scale);
	}
	// Update is called once per frame
	public void reSize () {
		Rigidbody rb = selected.GetComponent<Rigidbody>();
		if(sizeLocked){
			transform.parent = null;
			selected.tag = "sizeable";
			rb.useGravity = false;
			selected.transform.position = new Vector3(selected.transform.position.x, 1.0f, selected.transform.position.z);
			sizeLocked = false;
		}else if(!sizeLocked){
			rb.gameObject.tag = "pickable";
			rb.useGravity = true;
			sizeLocked = true;
		}
	}

	public void scale(float dist){
		if(!sizeLocked){
			selected.transform.localScale = new Vector3(dist *3.0F, dist *3.0F, dist *3.0F);
		}
	}
}
