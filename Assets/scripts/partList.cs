using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class partList : MonoBehaviour {
	public labels l;
	public GameObject button;
	public Scrollbar scrolly;
	public merge_body body;

	// Use this for initialization
	public void init () {
		Transform contentArea = transform.GetChild(0).GetChild(0);
		List<string> partsList = l.labelAll();
		float count = 0;
		foreach(string name in partsList){
			GameObject but = Instantiate(button);
			but.transform.Find("Text").GetComponent<Text>().text = name;
			but.transform.SetParent(contentArea);
			but.name = name;
			but.GetComponent<uiButtonPress>().body = body;
			RectTransform rect = but.GetComponent<RectTransform>();
			rect.anchoredPosition = button.GetComponent<RectTransform>().anchoredPosition;
			rect.anchoredPosition = new Vector2(0f, rect.anchoredPosition.y - count*40);
			rect.localPosition = new Vector3(rect.localPosition.x, rect.localPosition.y, 0f);
			but.transform.localRotation = button.transform.rotation;
			but.transform.localScale = button.transform.localScale;
			count+=1;
		}
		scrolly.numberOfSteps = contentArea.childCount;
		scrolly.size = 1/count;
	}
}
