using UnityEngine;
using System.Collections;


public class MoveCube : MonoBehaviour {

	private float x;
	private float y;
	private float t;

	void Start () {

		RandomMovement ();

		}
	

	// Update is called once per frame
	void Update () {

		t += Time.deltaTime;

		
		transform.Rotate (new Vector3 (15, 0, 0) * Time.deltaTime);

		// Move the object upward in world space 1 unit/second.
		transform.Translate(x * Time.deltaTime, 0, y * Time.deltaTime, Space.World);


		if (t >= Random.value * 100) 
		{
			RandomMovement ();
			t = 0;
		}
		
		
	}

	void RandomMovement ()
    { 
		x = (Random.value - 0.5f) * (Random.value * 50);
		y = (Random.value - 0.5f) * (Random.value * 50);
	}
}
