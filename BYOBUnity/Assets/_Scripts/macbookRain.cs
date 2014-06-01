using UnityEngine;
using System.Collections;

public class macbookRain : MonoBehaviour {

	private float x;
	private float z;

	// Use this for initialization
	void Start () {

		RandomPlace ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter (Collider other) 
	{
		RandomPlace ();
		transform.position =new Vector3(x, 200, z);
	}

	void RandomPlace ()
			{
			x = -10000 + Random.value * 20000;
			z = -10000 + Random.value * 20000;
		}
}
