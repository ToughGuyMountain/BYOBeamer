using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class StateMachine : MonoBehaviour {
	[SerializeField] private StateMachineState state;
	public StateMachineState State {
		get { return state; }
		private set { state = value; }
	}
	
    public Dictionary<string, StateMachineState> States { get; private set; }
    
	
	void Awake() {
		States = new Dictionary<string, StateMachineState>();
		var stateList = GetComponentsInChildren<StateMachineState>();
		foreach (var state in stateList) {
			States[state.gameObject.name] = state;
		}
	}
	
	[SerializeField] private bool _active = true;
	public bool Active {
		get { return _active; }
		set { _active = value; }
	}
	
	public bool ChangeState(string state) {
		return ChangeState(States[state]);
	}
	
	public bool ChangeState(StateMachineState to) {
		bool changedState;
		if (CanChangeState(to)) {
			var from = State;
			if (from) from.OnExit();
			State = to;
	        if (to) to.OnEnter();
			changedState = true;
		}
		else {
			changedState = false;
		}
		
        return changedState;
	}
	
	public bool CanChangeState(StateMachineState to) {
		bool result;
		
		if (Active) {
			if (to == null) result = false;
			else result = true;
		}
		else {
			result = false;
		}
		
		return result;
	}
}