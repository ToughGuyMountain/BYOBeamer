using UnityEngine;
using System;
using System.Collections;

public class PlayMovie : MonoBehaviour {
	public bool loop;
	public bool playOnStart;
	public Action onFinished;
	bool playing;
	MovieTexture movTexture;
	
	void Start () {
		movTexture = renderer.material.mainTexture as MovieTexture;
		if (playOnStart) {
			Play();
		}
	}
	
	public void Play() {
		movTexture.loop = loop;
		movTexture.Play();
		if (onFinished != null) {
			StartCoroutine(SignalWhenFinished());
		}
	}
	
	IEnumerator SignalWhenFinished() {
		while(movTexture.isPlaying) { yield return null; }
		if (onFinished != null) onFinished();
	}
}