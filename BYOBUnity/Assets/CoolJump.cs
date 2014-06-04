using UnityEngine;
using System.Collections;

public class CoolJump : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		NoDeath ();
	}

	void OnCollisionEnter (Collision info) {

		rigidbody.AddForce (info.contacts[0].normal * (200 + UnityEngine.Random.value * 200), ForceMode.Acceleration);

	}

	void NoDeath () {

		if (Mathf.Approximately(rigidbody.velocity.magnitude, 0)) {

			rigidbody.AddForce (Vector3.up * 50, ForceMode.Acceleration);

		}

	}
}
