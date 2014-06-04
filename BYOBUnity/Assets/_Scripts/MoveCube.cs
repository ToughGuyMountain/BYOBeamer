using UnityEngine;
using System.Collections;


public class MoveCube : MonoBehaviour {

	private float x;
	private float y;
	private float t;

	void Start () {

		RandoPositio ();
		RandomMovement ();

		}
	

	// Update is called once per frame
	void Update () {

		t += Time.deltaTime;



		transform.Translate(x * Time.deltaTime, 0, y * Time.deltaTime, Space.World);


		if (t >= Random.value * 100) 
		{
			RandomMovement ();
			t = 0;
		}
		
		
	}

	void RandomMovement ()
    { 
		x = (Random.value - 0.5f) * (Random.value * 25);
		y = (Random.value - 0.5f) * (Random.value * 25);

		transform.Rotate(0, 90, 0, Space.World);

	}

	void OnCollisionEnter (Collision collision) {

		RandoPositio ();

	}

	void RandoPositio () {

		transform.position = new Vector3((UnityEngine.Random.value * 200 - 100), 93, (UnityEngine.Random.value * 200 - 100));
	}
}
