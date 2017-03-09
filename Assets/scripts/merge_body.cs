using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class merge_body : MonoBehaviour {
	public controller_stuff controller;
	public GameObject first;
	public GameObject last;
	public GameObject body;
	float firstPos;
	float count = 0;
	public bool locked = false;
	GameObject[] parts;
	GameObject selected;
	int index = 0;

	// Use this for initialization
	void Start () {
		firstPos = first.transform.position.z;
	}

	void Awake(){
		foreach(Transform part in body.transform){
			parts[(int)count] = part.gameObject;
			Debug.Log(count);
			count+=1;
		}
	}
	
	// Update is called once per frame
	void Update () {
		if(controller.grip && locked){
			locked = false;
		}else if(controller.grip && !locked){
			locked = true;
			index = 0;
		}
		if(!locked && controller.totalDist > 0.2){
			float incount = 0;
			foreach(Transform part in body.transform){
				incount+=1;
				part.position = new Vector3(part.position.x, part.position.y, firstPos + (controller.totalDist*10 * (incount/count)));
			}
		}

		if(locked){
			if(controller.swipeUp){
				if(index < parts.Length)
					index+=1;
				else
					index = 0;

			}else if(controller.swipeDown){
				if(index > 0)
					index-=1;
				else
					index = parts.Length - 1;
			}

			selected = parts[index];
			Debug.Log(selected.name);
		}
	}
}