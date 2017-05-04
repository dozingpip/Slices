using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRStandardAssets.Utils;
using UnityEngine.Events;

public class merge_body : MonoBehaviour {
	public GUIArrows arrows;
	public Transform indicator, OriginTransform, selected = null;
	public bool locked = false;
	Transform lastSelected;
	float index;
	int timeScrolling;
	float speedD = 4f;
	float speed;
	public float scrollSmallestInc;
	UnityEvent grip, canTeleport;
	FloatEvent scroll, totalDist;

	// Use this for initialization
	void Start () {
		//grip.AddListener(gripped);
		//canTeleport.AddListener(can_teleport);
		//scroll.AddListener(scrollUpdate);
		//totalDist.AddListener(accordion);
	}

	public void gripped () {
		if(locked){
			selected = null;
			locked = false;
			//after just unlocking position, set all the parts to their proper positions
			foreach(Transform part in transform){
				part.position = new Vector3(0, transform.position.y, part.position.z);
			}
			selected.gameObject.tag = "body";
			Object.Destroy(selected.GetComponent<Rigidbody>());
		}else if(!locked){
			index = 0;
			locked = true;
		}
	}

	public void accordion(float dist){
		//if parts are unlocked and the controllers aren't too close together
		if(!locked && dist > 0.2){
			float incount = 0;
			//vary position based on which index the part is in in the hierarchy.
			foreach(Transform part in transform){
				incount+=1;
				//stay centered on the x, keep the main body's y position, but then for the z axis, base it on the distance 
				//between the controllers* a constant* what index the part is at in the local hierarchy of the body
				part.position = new Vector3(0, transform.position.y, (dist*10 * (incount/transform.childCount) ) );
			}
		}
	}

	public void can_teleport(){
		if(selected != null){
			teleportTo(selected.name);
		}
	}

	public void scrollUpdate(float scrollAmount){
		if(locked){
			if(scrollAmount > 0.2f){
				speed = scrollSwitch(scrollAmount);
				if(index + speed < transform.childCount - 1)
					index+= speed;
				else
					index = 0;
				lastSelected = selected;
				//adjust the position of the indicator block to show where you're scrolling and
				// how fast index is being incremented
				updateIndicator(index);
			}else if(scrollAmount < -0.2f){
				speed = scrollSwitch(-scrollAmount);
				if(index -speed > 0)
					index-=speed;
				else
					index = transform.childCount-1;
				lastSelected = selected;
				updateIndicator(index);
			}else{
				timeScrolling = 0;
				selected = transform.GetChild((int)Mathf.Round(index));
				select(selected, lastSelected);
			}
		}
	}

	void updateIndicator(float i){
		indicator.position = new Vector3(0, indicator.position.y, transform.GetChild((int)Mathf.Round(index)).position.z);
		timeScrolling+=1;
	}


	public void teleportTo(string partName){
		//Debug.Log("teleporting to " + partName);
		Vector3 offset = new Vector3(0f, -1.0f, 0.2f);
		OriginTransform.position = transform.Find(partName).position + offset;
	}
	
	void select(Transform s, Transform ls){
		s.gameObject.tag = "pickable body";
		s.Find("label(Clone)").gameObject.GetComponent<showLabel>().show();
		if(s.gameObject.GetComponent<Rigidbody>() == null)
			s.gameObject.AddComponent<Rigidbody>();
		if(ls != null){
			ls.gameObject.tag = "body";
			s.Find("label(Clone)").gameObject.GetComponent<showLabel>().hide();
		}
		if (s != ls)
			updateLastSelected(ls);
	}

	void updateLastSelected(Transform ls){
		if(ls != null){
			float step = speedD * Time.deltaTime;
			Vector3 toward = new Vector3(transform.position.x, transform.position.y, ls.position.z);
     		ls.position = Vector3.MoveTowards(ls.position, toward, step);
     		ls.rotation = Quaternion.Euler(90f, 0f, 0f);
     		if(ls.gameObject.GetComponent<FixedJoint>() != null)
     			Object.Destroy(ls.gameObject.GetComponent<FixedJoint>());
     		Object.Destroy(ls.gameObject.GetComponent<Rigidbody>());
		}
	}

	float scrollSwitch(float scrollAmount){
		if(scrollAmount > 0.8){
			speed = scrollSmallestInc*4*(timeScrolling/30);
		}else if (scrollAmount > 0.5){
			speed = scrollSmallestInc*2;
		}else if (scrollAmount > 0.2){
			speed = scrollSmallestInc;
		}
		return speed;
	}
}