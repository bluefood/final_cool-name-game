using UnityEngine;
using System.Collections;

public class clockRotation : MonoBehaviour {
	private float time;
	public float startingRotation,timeMod;
	// Use this for initialization
	void Start () {
		time = transform.rotation.y;
	}
	
	// Update is called once per frame
	void Update () {
		if (timeMod == 0) {
			timeMod = 0.001f;
		}
		time += Time.deltaTime;
		if (time < 360/timeMod) {
			time += Time.deltaTime*timeMod;
		} else
			time = 0;
		transform.eulerAngles = new Vector3 (0,time*timeMod, 0);
		
	}
}
