using UnityEngine;
using System.Collections;

public class flashlight : MonoBehaviour {
	buttons b;
	public bool on = false;
	GameObject llight;
	// Use this for initialization
	void Start () {
		GameObject main = GameObject.Find("Main Control");
		b = main.GetComponent<buttons> ();
		llight = transform.Find ("Spotlight").gameObject;
		llight.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (b.checkButtons () == "Flashlight") {
			if (on) {
				llight.SetActive (false);
				on = false;
			} else {
				llight.SetActive (true);
				on = true;
			}
		}
	}
}
