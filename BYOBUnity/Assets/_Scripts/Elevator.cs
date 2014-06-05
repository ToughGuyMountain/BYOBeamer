using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {
	public string up;
	public string down;

	void ElevateUp() {
		Debug.Log("elevate");
		CutScene.Instance.PlayElevatorScene(up);
	}
	
	void ElevateDown() {
		CutScene.Instance.PlayElevatorScene(down);
	}
}