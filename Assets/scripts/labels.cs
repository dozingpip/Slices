using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labels : MonoBehaviour {
	public GameObject label;
	// Use this for initialization
	void Start () {
		foreach(GameObject part in GameObject.FindGameObjectsWithTag("pickable body")){
			GameObject temp = Instantiate(label);
			temp.transform.parent = part.transform;
			temp.transform.Find("text").GetComponent<TextMesh>().text = part.name;
			temp.transform.position = part.transform.position;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
