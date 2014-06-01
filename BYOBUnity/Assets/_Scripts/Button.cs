using UnityEngine;
using System.Collections;
using InControl;

public class Button : MonoBehaviour {
	bool playerNear; 
	public GameObject target;
	public string message;
	
	void OnTriggerEnter(Collider other) {
		Debug.Log (other);
		if (other.gameObject.IsPlayer()) {
			Debug.Log ("near");
			playerNear = true;
		}
	}
	
	void OnTriggerExit(Collider other) {
		if (other.gameObject.IsPlayer()) {
			playerNear = true;
		}
	}
	
	void Update() {
		var inputDevice = InputManager.ActiveDevice;
	
		if (playerNear && inputDevice.Action3) {
			target.SendMessage(message);
		}
	}
}