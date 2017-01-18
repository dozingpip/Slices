using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PFixedJoint : MonoBehaviour {
	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;
	public Rigidbody rigidbodyAttachpt;
	public Transform obj;

	FixedJoint fixedJoint;

	// Use this for initialization
	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		device = SteamVR_Controller.Input((int)trackedObj.index);
		if(device.GetPressUp(SteamVR_Controller.ButtonMask.Touchpad)){
			obj.transform.position = Vector3.zero;
			obj.GetComponent<Rigidbody>().velocity = Vector3.zero;
			obj.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		}
	}

	void OnTriggerStay(Collider col){
		if(fixedJoint ==null && device.GetTouch(SteamVR_Controller.ButtonMask.Trigger)){
			fixedJoint = col.gameObject.AddComponent<FixedJoint>();
			fixedJoint.connectedBody = rigidbodyAttachpt;
		}else if(fixedJoint != null && device.GetTouch(SteamVR_Controller.ButtonMask.Trigger)){
			GameObject go = fixedJoint.gameObject;
			Rigidbody rigidbody = go.GetComponent<Rigidbody>();
			Object.Destroy(fixedJoint);
			fixedJoint = null;
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
