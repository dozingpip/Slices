using UnityEngine;
using System.Collections;
using UnityEngine.Events;

public class buttons : MonoBehaviour {
	public UnityEvent trigger, triggerUp, menu, leftMenu, rightMenu, grip, canTeleport;
	UnityEvent vive_grip, vive_menu, vive_triggerup, vive_trigger, vive_leftMenu, vive_rightMenu, on;
	public FloatEvent scroll;
	FloatEvent vive_scroll;
	
	public void trig(){
		trigger.Invoke();
	}

	public void trigUp(){
		triggerUp.Invoke();
	}

	public void gripped(){
		grip.Invoke();
	}

	public void m(){
		menu.Invoke();
	}

	public void left(){
		leftMenu.Invoke();
	}

	public void right(){
		rightMenu.Invoke();
	}

	public void scrollIt(float scrollAmount){
		scroll.Invoke(scrollAmount);
	}

	public void Update(){
		if (Input.GetKeyDown (KeyCode.E)) {
			trigger.Invoke();
		} else if(Input.GetKeyUp (KeyCode.E)){
			triggerUp.Invoke();
		}else if (Input.GetKeyDown (KeyCode.F)) {
			grip.Invoke();
		} else if(Input.GetKey("q")){
			Application.Quit();
		}

		scroll.Invoke(Input.GetAxis("Mouse ScrollWheel"));
	}
}