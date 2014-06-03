using UnityEngine;
using System.Collections;

public class EnableOnRemoteState : MonoBehaviour {
	[SerializeField] StateMachineState state;
	[SerializeField] Behaviour behaviour;
	
	void Start() {
		state.Enter += Enter;
		state.Exit += Exit;
		// give 'em a chance to start up
		StartCoroutine(
			Util.AfterOneFrame(
			() => { if (!state.Active) behaviour.enabled = false; }
		)
			);
	}
	
	void Enter() {
		behaviour.enabled = true;
	}
	
	void Exit() {
		behaviour.enabled = false;
	}
}
