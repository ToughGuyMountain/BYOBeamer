using UnityEngine;
using System.Collections;

public class Game : Singleton<Game> {
	public StateMachine Machine { get; private set; }
	
	void Awake() {
		base.Awake();
		Machine = GetComponent<StateMachine>();
	}
}
