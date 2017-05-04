using UnityEngine;
using System.Collections;
using UnityEngine.VR;

public class toggle_vr : MonoBehaviour {
	public GameObject vr;
	public GameObject other;
	public Camera other_cam;
	// Use this for initialization
	void Start () {
		vr = GameObject.FindWithTag("vr_rig");
		other = GameObject.FindWithTag("not_vr");
		other.SetActive (false);
		vr.transform.gameObject.tag = "Player";
	}
	
	//TODO: fix the height of vr cam being transfered to other_cam always
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Tab)){
			if (vr.activeSelf) {
				VRSettings.enabled = false;
				vr.SetActive(false);
				other.SetActive(true);
				vr.transform.gameObject.tag = "vr_rig";
				other.transform.position = vr.transform.position;
				other.transform.rotation = vr.transform.rotation;
				other.transform.gameObject.tag = "Player";
				other_cam.enabled = true;
				other_cam.fieldOfView = 60.0F;
			}else{
				other_cam.enabled = false;
				VRSettings.enabled = true;
				other.SetActive(false);
				vr.SetActive(true);
				other.transform.gameObject.tag = "not_vr";
				vr.transform.position = other.transform.position;
				vr.transform.rotation = other.transform.rotation;
				vr.transform.gameObject.tag = "Player";
			}
		}
	}
}
