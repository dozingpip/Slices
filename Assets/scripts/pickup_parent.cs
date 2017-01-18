using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class pickup_parent : MonoBehaviour {
	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;
	public Text text;
	// Use this for initialization
	void Start () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
		text.text = "boop";
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		device = SteamVR_Controller.Input((int)trackedObj.index);
		if(device.GetTouch(SteamVR_Controller.ButtonMask.Trigger)){
			Debug.Log("boop");
		}
	}
	
	void OnTriggerStay(Collider col){
		Debug.Log(col.name+"bap");
		if(device.GetTouch(SteamVR_Controller.ButtonMask.Trigger)){
			Debug.Log("collided with" +col.name+"while holding");
			col.attachedRigidbody.isKinematic = true;
			col.gameObject.transform.SetParent(gameObject.transform);
			text.text = "collided with" +col.name+"while holding";
		}
		if(device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger)){
			col.gameObject.transform.SetParent(null);
			col.attachedRigidbody.isKinematic = false;
			tossObject(col.attachedRigidbody);
			text.text = "dropped"+col.name;
		}
	}

	void tossObject(Rigidbody rigidBody){
		//convert local vectors to worldspace vectors
		//ternary operator means if thing before ? is true, return the first value, if false return the value after the colon.
		Transform origin = trackedObj.origin ? trackedObj.origin: trackedObj.transform.parent;
		if(origin != null){
			rigidBody.velocity = origin.TransformVector(device.velocity);
			rigidBody.angularVelocity = origin.TransformVector(device.angularVelocity);
		}else{
			rigidBody.velocity = device.velocity;
			rigidBody.angularVelocity = device.angularVelocity;
		}
	}
}
