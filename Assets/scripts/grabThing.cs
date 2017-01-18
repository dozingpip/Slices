using UnityEngine;
using System.Collections;

public class grabThing : MonoBehaviour {
	public float range;
	buttons b;
	GameObject[] handspots;
	// Use this for initialization
	void Start () {
		GameObject main = GameObject.Find("Main Control");
		b = main.GetComponent<buttons> ();
		handspots = GameObject.FindGameObjectsWithTag ("handspot");
	}

	// Update is called once per frame
	void Update () {
		if (Vector3.Distance (transform.position, b.vr.Player.transform.position) < range) {
			if (b.checkButtons () == "Pickup") {
				pickUp ();
			} else if (b.checkButtons () == "vrPickupR") {
				pickUp (b.rightC);
			}
		}
	}

	void pickUp (GameObject picker = null){
		//foreach (GameObject spot in handspots) {
			//handItems handitem = spot.GetComponent<handItems> ();
			//handitem.picked = true;
		//}
		/*if (picker != null) {
			b.leftC.transform.Find("hand"+gameObject.name).gameObject.SetActive(false);
		}*/
		Destroy (gameObject);
	}
}
