using UnityEngine;
using System.Collections;

public class heatSeekers : MonoBehaviour {

	GameObject prefab;
	
	public float heatSeekVel = 222f;     //vel scale
	
	public GameObject shootPoint;        // spawn point for 
	//public GameObject targ;


	// Use this for initialization
	void Start () 
		{
		prefab = Resources.Load("heatseeker") as GameObject;
		//targ = GameObject.FindGameObjectsWithTag("nme");
		}


	// Update is called once per frame
	void Update () 
	{
		

		if(Input.GetMouseButtonDown(0))      //if click
		{
			GameObject heatseeker = Instantiate(prefab) as GameObject;        //instantiate a prefab "heat seeker"
			heatseeker.transform.position=shootPoint.transform.position;       // at shootpoint

			Rigidbody rb = heatseeker.GetComponent<Rigidbody>();               // add rigidbody
			//rb.transform.LookAt(targ.transform);

			rb.AddRelativeForce(transform.forward * heatSeekVel);    // forward velocity
			rb.AddRelativeForce(transform.up*Random.Range(2f,53f));  //random up force




		}
	}
}
