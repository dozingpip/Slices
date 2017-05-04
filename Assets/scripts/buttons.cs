using UnityEngine;
using System.Collections;

public class buttons : MonoBehaviour {
	public toggle_vr vr;
	public controller_stuff controller;
	public bool trigger;
	public bool leftMenu;
	public bool rightMenu;
	public bool grip;
	public bool touching;
	public bool canTeleport;
	public float scroll;
	// Use this for initialization
	void Start () {
		vr = GetComponent<toggle_vr>();
	}

	// Update is called once per frame
	void Update () {
		if(touching && !vr.on){
			Debug.Log("boop");
		}
	}
	
	public void checkButtons(){
		if (vr.on) {
			if(controller.trigger && !controller.touching){
				canTeleport = true;
			}else{
				canTeleport = false;
			}
		}else{
			if (Input.GetKeyDown (KeyCode.E)) {
				trigger=true;
			} else if (Input.GetKeyDown (KeyCode.F)) {
				Debug.Log("f");
			} else if(Input.GetKey("q")){
				Application.Quit();
			}else{
				trigger = false;
			}
		}
	}
}