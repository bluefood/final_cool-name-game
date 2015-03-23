using UnityEngine;
using System.Collections;

public class lookAT : MonoBehaviour {
	public GameObject yourHitpoint;
	// Use this for initialization
	void Start () {

		//player = GameObject.Find("Player");
		
	
	}
	
	// Update is called once per frame
	void Update () {
		//Player = GameObject.Find("Player");
		Quaternion targetRot = Quaternion.LookRotation(yourHitpoint.transform.position - transform.position);  //calc angle tween camera and player
				transform.rotation = Quaternion.Lerp(transform.rotation, targetRot,Time.deltaTime);
	//this.transform.LookAt(yourHitpoint.transform);
	}


}
