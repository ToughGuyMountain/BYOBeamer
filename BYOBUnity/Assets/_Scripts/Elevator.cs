using UnityEngine;
using System.Collections;

public class Elevator : MonoBehaviour {
	public Transform up;
	public Transform down;

	void ElevateUp() {
		CutScene.Instance.PlayElevatorScene();
		Player.Instance.transform.position = up.position;
		Player.Instance.transform.forward = up.forward;
	}
	
	void ElevateDown() {
		CutScene.Instance.PlayElevatorScene();
		Player.Instance.transform.position = down.position;
		Player.Instance.transform.forward = down.forward;
	}
}