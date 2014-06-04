using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {
	public string up;
	public string down;

	void ElevateUp() {
		CutScene.Instance.PlayElevatorScene(up);
	}
	
	void ElevateDown() {
		CutScene.Instance.PlayElevatorScene(down);
	}
}