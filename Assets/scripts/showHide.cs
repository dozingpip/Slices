using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class showHide : MonoBehaviour {
	public bool listShown, guideShown;
	GameObject ui;
	public GameObject guide, listView;
	public Transform listShowPos, listHidePos, guideShowPos, guideHidePos, origTransform;
	float speed = 4f;
	public UnityEvent leftMenu, rightMenu;

	// Use this for initialization
	void Start () {
		ui = transform.Find("main ui").gameObject;
		guideShown = true;
		listShown = false;
		listView.GetComponent<partList>().init();
	}
	
	public void rightMenuVisibility () {
		if(!guideShown){
			hideList();
			showGuide();
		}else if(guideShown){
			hideGuide();
		}
	}

	public void leftMenuVisibility(){
		if(!listShown){
			hideGuide();
			showList();
		}else if(listShown){
			hideList();
		}
	}

	void showList(){
		listShown = true;
		ui.SetActive(true);
		listView.transform.localScale = changeScale(listShowPos.localScale, listView.transform.localScale, 1.0f);
		listView.transform.position = Vector3.MoveTowards(listView.transform.position, listShowPos.position, speed*Time.deltaTime);
	}

	public void hideList(){
		listShown = false;
		listView.transform.localScale = changeScale(listShowPos.localScale, listView.transform.localScale, 0.2f);
		listView.transform.position = Vector3.MoveTowards(listView.transform.position, listHidePos.position, speed*Time.deltaTime);
	}

	public void showGuide(){
		guideShown = true;
		guide.transform.localScale = changeScale(guideShowPos.localScale, guide.transform.localScale, 3f);
		guide.transform.position = Vector3.MoveTowards(guide.transform.position, guideShowPos.position, speed*Time.deltaTime);
	}

	public void hideGuide(){
		guideShown = false;
		guide.transform.localScale = changeScale(guideHidePos.localScale, guide.transform.localScale, 0.2f);
		guide.transform.position = Vector3.MoveTowards(guide.transform.position, guideHidePos.position, speed*Time.deltaTime);
	}

	Vector3 changeScale(Vector3 baseScale, Vector3 current, float scalar){
		Vector3 temp = new Vector3(baseScale.x*scalar, baseScale.y*scalar, baseScale.z*scalar);
		return Vector3.Lerp(current, temp, 6.0f*Time.deltaTime);
	}
}
