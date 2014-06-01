using UnityEngine;
using System.Collections;

public class BrandHunter : MonoBehaviour {

	//public GUIText brandCount;

	private int apple;
	private int google;
	private int miami;
	private int star;

	// Use this for initialization
	void Start () {
		apple = 0;
		google = 0;
		miami = 0;
		star = 0;
	}
	
	void OnTriggerEnter (Collider other) 
	{
		if(other.gameObject.tag == "apple")
		{
			apple = apple + 1;
		}
		else if(other.gameObject.tag == "google")
		{
			google = google + 1;
		}
		else if(other.gameObject.tag == "miami")
		{
			miami = miami + 1;
		}
		else if(other.gameObject.tag == "starbux")
		{
			star = star + 1;
		}
	}

	void OnGUI() {
		GUI.Label (new Rect (15, 15, 200, 40), "APPLE BRANDS COLLECTED: " + apple.ToString ());
		GUI.Label (new Rect (15, 45, 400, 40), "GOOGLE BRANDS COLLECTED: " + google.ToString ());
		GUI.Label (new Rect (15, 75, 400, 40), "MIAMI DOLPHINS BRANDS COLLECTED: " + miami.ToString ());
		GUI.Label (new Rect (15, 105, 400, 40), "STARBUCKS BRANDS COLLECTED: " + star.ToString ());
	}
	
}
