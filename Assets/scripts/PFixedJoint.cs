using UnityEngine;
using System.Collections;

[RequireComponent(typeof(SteamVR_TrackedObject))]
public class PFixedJoint : MonoBehaviour {
	SteamVR_TrackedObject trackedObj;
	SteamVR_Controller.Device device;
	public Rigidbody rigidbodyAttachpt;
	FixedJoint fixedJoint;

	void Awake () {
		trackedObj = GetComponent<SteamVR_TrackedObject>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		device = SteamVR_Controller.Input((int)trackedObj.index);
	}

	void OnTriggerStay(Collider col){
		Rigidbody rb = col.gameObject.GetComponent<Rigidbody>();
		if(fixedJoint == null && device.GetTouch(SteamVR_Controller.ButtonMask.Trigger) && col.gameObject.tag.Contains("pickable")){
			fixedJoint = col.gameObject.AddComponent<FixedJoint>();
			fixedJoint.connectedBody = rigidbodyAttachpt;
			if(col.gameObject.tag.Contains("body")){
				col.gameObject.transform.Find("label(Clone)").gameObject.GetComponent<showLabel>().show();
			}
		}else if(fixedJoint != null && device.GetTouchUp(SteamVR_Controller.ButtonMask.Trigger)){
			GameObject go = fixedJoint.gameObject;
			Rigidbody rigidbody = go.GetComponent<Rigidbody>();
			Object.Destroy(fixedJoint);
			fixedJoint = null;
			col.gameObject.transform.parent = null;
			tossObject(rigidbody);
			if(go.tag.Contains("body")){
				go.transform.Find("label(Clone)").gameObject.GetComponent<showLabel>().hide();
			}
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
