using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PFixedJoint : MonoBehaviour {
	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;
	public Rigidbody rigidbodyAttachpt;
	FixedJoint fixedJoint;
	Vector3 origPos;
	Transform origParent;

	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		device = SteamVR_Controller.Input((int)trackedObj.index);
	}

	void OnTriggerStay(Collider col){
		Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
		//if the fixedjoint isnt there, the trigger button is pressed, and object is pickable
		if(fixedJoint == null && device.GetTouch(SteamVR_Controller.ButtonMask.Trigger) && col.gameObject.tag.Contains("pickable")){
			//add the fixed joint and attach it to the controller (in hierarchy and with fixed joint)
			fixedJoint = col.gameObject.AddComponent<FixedJoint>();
			fixedJoint.connectedBody = rigidbodyAttachpt;
		//if the fixed joint is already there, and the trigger has just been unpressed, must be dropping the object
		}else if(fixedJoint != null && device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger)){
			GameObject go = fixedJoint.gameObject;
			Rigidbody rigidbody = go.GetComponent<Rigidbody>();
			Object.Destroy(fixedJoint);
			fixedJoint = null;

			//if the object has "body" tag
			if(!go.tag.Contains("body")){
				//all the things relating to physically dropping the object
				tossObject(rigidbody);
			}
		}
		if(rb != null)
			rb.WakeUp();
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
