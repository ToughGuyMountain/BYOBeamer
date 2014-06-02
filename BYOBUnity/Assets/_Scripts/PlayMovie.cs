using UnityEngine;
using System.Collections;

public class PlayMovie : MonoBehaviour {
	
	void Start () {
		var movTexture = renderer.material.mainTexture as MovieTexture;
		movTexture.loop = true;
		movTexture.Play();
	}

}