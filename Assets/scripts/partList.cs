using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class partList : MonoBehaviour {
	public labels l;
	List<string> partsList;
	public GameObject button;
	public Transform contentArea;
	public Scrollbar scrolly;
	public merge_body body;
	float count;

	// Use this for initialization
	void Start () {
		partsList = l.partList;
		count = 0;
		foreach(string name in partsList){
			GameObject but = Instantiate(button);
			but.transform.Find("Text").GetComponent<Text>().text = name;
			but.transform.SetParent(contentArea);
			but.name = name;
			but.GetComponent<uiButtonPress>().body = body;
			but.transform.localPosition = button.transform.position;
			but.transform.localPosition = new Vector3(but.transform.localPosition.x, but.transform.localPosition.y -150 - count*40, but.transform.localPosition.z);
			but.transform.localRotation = button.transform.rotation;
			but.transform.localScale = button.transform.localScale;
			count+=1;
		}
		scrolly.numberOfSteps = contentArea.childCount;
		scrolly.size = 1/count;
		gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {

	}
}
