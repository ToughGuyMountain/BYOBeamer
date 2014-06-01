using UnityEngine;
using System.Collections;

public class Brand : MonoBehaviour {

	private float x;
	private float y;
	private float t;
	private float a;
	private float b;


	void Start () {
		GenerateMovementForce ();
		GenerateStartingPosition ();


	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{

			ApplyFreeMovement();
	
	}
	

	void ApplyFreeMovement() {
		t += Time.deltaTime;

		
		transform.Translate (x * Time.deltaTime, 0, y * Time.deltaTime, Space.World);
		
		
		if (t >= Random.value * 100) 
		{
			GenerateMovementForce();
			t = 0;
		}
	}

	void GenerateMovementForce()
	{ 
		x = Random.value * 10;
		y = Random.value * 10;
	}

	void GenerateStartingPosition()
	{
		a = -10000 + Random.value * 20000;
		b = -10000 + Random.value * 20000;

		transform.position = new Vector3 (a, 3, b);

		}

	void OnTriggerExit(Collider other)
	{
		if (other.gameObject.tag == "Respawn") {
			GenerateStartingPosition();
				}
		}

	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "Player")
		{
			GenerateStartingPosition();
		}



	}


	
}
