using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class showHide : MonoBehaviour {
	public controller_stuff controller;
	public bool listShown;
	public bool guideShown;
	GameObject ui;
	public GameObject guide;
	public GameObject listView;
	public Transform listShowPos;
	public Transform listHidePos;
	public Transform guideShowPos;
	public Transform guideHidePos;
	static Transform origTransform;
	float speed = 4f;

	// Use this for initialization
	void Start () {
		ui = transform.Find("main ui").gameObject;
		guideShown = true;
		listShown = false;
		listView.GetComponent<partList>().init();
		ui.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
		if(controller.leftMenu && !listShown){
			guideShown = false;
			listShown = true;
		}else if(controller.leftMenu && listShown){
			listShown = false;
		}

		if(controller.rightMenu && !guideShown){
			listShown = false;
			guideShown = true;
		}else if(controller.rightMenu && guideShown){
			guideShown = false;
		}

		if(listShown){
			showList();
		}else{
			hideList();
		}

		if(guideShown){
			showGuide();
		}else{
			hideGuide();
		}
	}

	public void showList(){
		listView.transform.localScale = changeScale(listShowPos.localScale, listView.transform.localScale, 1.0f);
		listView.transform.position = Vector3.MoveTowards(listView.transform.position, listShowPos.position, speed*Time.deltaTime);
	}

	public void hideList(){
		listView.transform.localScale = changeScale(listShowPos.localScale, listView.transform.localScale, 0.2f);
		listView.transform.position = Vector3.MoveTowards(listView.transform.position, listHidePos.position, speed*Time.deltaTime);
		listShown = false;
	}

	public void showGuide(){
		guide.transform.localScale = changeScale(guideShowPos.localScale, guide.transform.localScale, 3f);
		guide.transform.position = Vector3.MoveTowards(guide.transform.position, guideShowPos.position, speed*Time.deltaTime);
	}

	public void hideGuide(){
		guide.transform.localScale = changeScale(guideHidePos.localScale, guide.transform.localScale, 0.2f);
		guide.transform.position = Vector3.MoveTowards(guide.transform.position, guideHidePos.position, speed*Time.deltaTime);
	}

	Vector3 changeScale(Vector3 baseScale, Vector3 current, float scalar){
		Vector3 temp = new Vector3(baseScale.x*scalar, baseScale.y*scalar, baseScale.z*scalar);
		return Vector3.Lerp(current, temp, 6.0f*Time.deltaTime);
	}
}
