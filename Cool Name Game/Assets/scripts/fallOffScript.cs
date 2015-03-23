using UnityEngine;
using System.Collections;

public class fallOffScript : MonoBehaviour {

	
		public Vector3 uplimit ;
		public Vector3 lowlimit ;
		public Vector3 spawn;
	
	// Update is called once per frame
	void Update () {

		
		//nme.position = Enemyz;


		if(transform.position.y <= lowlimit.y)
		{
			transform.position= spawn ;	
			
			GetComponent<Rigidbody>().velocity = Vector3.zero;
		}

		if(transform.position.y >= uplimit.y)
		{
			transform.position= spawn;
		}
	
	}
}
