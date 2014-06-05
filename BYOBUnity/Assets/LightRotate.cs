using UnityEngine;
using System.Collections;

public class LightRotate : MonoBehaviour {

	// Update is called once per frame
	void Update () {
	
		transform.Rotate(Vector3.up * Time.deltaTime * 20, Space.World);
	}
}
