using UnityEngine;
using System.Collections;

public class lazerScript : MonoBehaviour {

	public GameObject nme;
	public Transform startLaz;
	public Transform endLaz;
	LineRenderer lazerLine;

	// Use this for initialization
	void Start () {
		lazerLine = GetComponent<LineRenderer>();
		lazerLine.SetWidth(.2f, .2f);
	
	}
	void FixedUpdate()
	{
		startLaz.position = transform.position;
		//endLaz = nme.transform.position;

	}
		
	
	// Update is called once per frame
	void Update () 
		{
			lazerLine.SetPosition(0, startLaz.position);
			lazerLine.SetPosition(1, endLaz.position);
		
		}
}
