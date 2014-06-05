using UnityEngine;
using System.Collections;

public class CutScene : Singleton<CutScene> {
	public Material elevatorMaterial;
	public Renderer screen;
	PlayMovie movie;
	StateMachineState state;
	string nextLevel;

	void Start() {
		movie = screen.GetComponent<PlayMovie>();
		state = GetComponent<StateMachineState>();
	}

	public void PlayElevatorScene(string floorName) {
		Debug.Log (floorName);
		nextLevel = floorName;
		state.SwitchTo();
		screen.material = elevatorMaterial;
		movie.onFinished += EndElevatorScene;
		movie.Play();
	}
	
	void EndElevatorScene() {
		movie.onFinished -= EndElevatorScene;
		state.SwitchFrom();
		Application.LoadLevel(nextLevel);
	}
}