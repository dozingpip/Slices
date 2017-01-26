using UnityEngine;
using System.Collections;

public class flashlight : MonoBehaviour {
	//buttons b;
	//public bool on = false;
	GameObject llight;
	public float light;
	// Use this for initialization
	void Start () {
		//GameObject main = GameObject.Find("Main Control");
		//b = main.GetComponent<buttons> ();
		//llight = transform.Find ("Spotlight").gameObject;
		//llight.SetActive (false);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		/*if (b.checkButtons () == "Flashlight") {
			if (on) {
				llight.SetActive (false);
				on = false;
			} else {
				llight.SetActive (true);
				on = true;
			}
		}*/
		RaycastHit hit;
		Vector3 forward = transform.TransformDirection(Vector3.forward);
        //Debug.DrawRay(transform.position, forward, Color.green);
		Ray ray = new Ray (transform.position, forward);
        if (Physics.Raycast(transform.position, forward, out hit, light) && hit.collider.gameObject.tag == "enemy"){
                Debug.Log("boop!");
        		GameObject enemy = hit.collider.gameObject;
                if(hit.collider == enemy.GetComponent<StatePatternEnemy>().triggerBox){
        			enemy.GetComponent<StatePatternEnemy>().gotHit();
        		}
        }
	}

	/*void onTriggerStay(Collider col){
		if(col.gameObject.tag == "enemy" && col == col.GetComponent<StatePatternEnemy>().triggerBox){
			col.GetComponent<StatePatternEnemy>().health--;
		}
	}*/
}
