using UnityEngine;
using System.Collections;

public class ElevatorPlatform : MonoBehaviour {
	public Transform[] floors;
	int currentFloor;
	
	public void UpButtonPressed() {
		StartCoroutine(MoveTo(currentFloor + 1));
		//Player.Instance.transform.parent = transform;
	}	
	
	IEnumerator MoveTo(int floor) {
		var startPosition = transform.position;
		float t = 0;
		float time = 5;
		while (t < time) {
			transform.position = Vector3.Lerp(startPosition, floors[floor].position, t/time);
			t += Time.deltaTime;
			yield return null;
		}
		transform.position = Vector3.Lerp(startPosition, floors[floor].position, 1);
		currentFloor++;
	}
}
