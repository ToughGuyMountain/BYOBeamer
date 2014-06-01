using UnityEngine;
using System.Collections;
using InControl;

public class VisualTaunt : MonoBehaviour {
	public GameObject[] tauntPrefabs0;
	public GameObject[] tauntPrefabs1;
	int index0;
	int index1;
	
	void Update() {
		var inputDevice = InputManager.ActiveDevice;
		
		if (inputDevice.LeftTrigger) {
			index0 = (index0 + 1) % tauntPrefabs0.Length;
			Instantiate(tauntPrefabs0[index0], transform.position, Quaternion.identity);
		}
	}
}
