using UnityEngine;
using System.Collections;

public class RotateAtSpeed : MonoBehaviour {
	public float speed = 1.0f;
	public bool cw = true;
	public Vector3 axisOfRotation;
	float angle;
	public bool randomStartingOffset;
	
	void Start() {
		if (randomStartingOffset) {
			angle += UnityEngine.Random.value * 360;
		}
	}
	
	void Update() {
		angle += cw ? speed * Time.deltaTime : -speed * Time.deltaTime;
		transform.localRotation = Quaternion.AngleAxis(angle, axisOfRotation);
	}	
}
