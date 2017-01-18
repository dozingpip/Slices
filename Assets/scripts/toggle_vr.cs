using UnityEngine;
using System.Collections;

public class toggle_vr : MonoBehaviour {
	GameObject vr;
	GameObject other;
	public bool on;
	public GameObject Player;
	public GameObject ui;
	// Use this for initialization
	void Start () {
		vr = GameObject.FindWithTag("vr_rig");
		other = GameObject.FindWithTag("not_vr");
		vr.SetActive (true);
		other.SetActive (false);
		on = true;
		Player = vr;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab)){
			if (vr.activeSelf) {
				other.SetActive(true);
				vr.SetActive(false);
				other.transform.position = vr.transform.position;
				other.transform.rotation = vr.transform.rotation;
				Player = other;
				on = false;
			}else{
				vr.SetActive(true);
				other.SetActive(false);
				vr.transform.position = other.transform.position;
				vr.transform.rotation = other.transform.rotation;
				Player = vr;
				on = true;
			}
		}
	}
}
