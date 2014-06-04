using UnityEngine;
using System.Collections;

public class CoolJump : MonoBehaviour {
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnCollisionEnter (Collision info) {
		Debug.Log ("colliz");
		rigidbody.AddForce (info.contacts[0].normal * (200 + UnityEngine.Random.value * 200), ForceMode.Acceleration);

	}
}
