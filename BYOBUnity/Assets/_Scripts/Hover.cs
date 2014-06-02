using UnityEngine;
using System.Collections;

public class Hover : MonoBehaviour {
	public float range;
	public float hoverTime;
	float top;
 	float bottom;
	bool fromBottom;
	float t;
	
	void Start() {
		top = transform.localPosition.y + range / 2;
		bottom = transform.localPosition.y - range / 2;
		transform.localPosition = new Vector3(transform.localPosition.x, bottom, transform.localPosition.z);
		fromBottom = true;
	}
	
	void Update() {
		if (fromBottom) {
			transform.localPosition = new Vector3(transform.localPosition.x, Mathf.SmoothStep(bottom, top, t), transform.localPosition.z);
		}
		else {
			transform.localPosition = new Vector3(transform.localPosition.x, Mathf.SmoothStep(top, bottom, t), transform.localPosition.z);
		}
		
		t += Time.deltaTime / hoverTime;
		if (t >= 1) {
			t = 0;
			fromBottom = !fromBottom;
		}
	}
}
