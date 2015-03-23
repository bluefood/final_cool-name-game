using UnityEngine;
using System.Collections;

public class Squish : MonoBehaviour {

	bool squish = true;
	bool diving = false;
	void SquishNow ()
	{
		if (squish == true && transform.localScale != new Vector3 (24.2f, 16.7f,16.7f)) {   // if squished & squish bool is true
			if (diving == true) {
				diving = false;
				transform.localScale = Vector3.Lerp (transform.localScale, new Vector3 (.8f,.9f, .9f), Time.deltaTime * 55); // lerp scale
			} else {
				transform.localScale = Vector3.Lerp (transform.localScale, new Vector3 (24.2f, 16.7f, 16.7f), Time.deltaTime * 55); // lerp scale
			}
			if (transform.localScale == new Vector3 (24.2f, 16.7f,16.7f)) {
				squish = false;
				transform.localScale = new Vector3 (20, 20, 20);
			}  
		}
	}
	// Use this for initialization
	void Start () {
		InvokeRepeating ("SquishNow", 0.3f, 0.3f);
	}

	// Update is called once per frame
	void Update () {
		//SquishNow ();
	}
}
