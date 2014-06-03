using UnityEngine;
using System.Collections;
using InControl;

public class ButtonStateChange : MonoBehaviour {
	bool playerNear; 
	public StateMachine target;
	public string state;
	
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
			target.ChangeState(state);
		}
	}
}