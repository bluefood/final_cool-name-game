using UnityEngine;
using System.Collections;

public class heatSplode : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
void OnCollisionEnter ( Collision col)
	{
		GameObject prefab = Resources.Load("Splode") as GameObject;
		GameObject splode = Instantiate (prefab) as GameObject;
		splode.transform.position = transform.position;
		Destroy(splode, 10f);
		Destroy (gameObject);

	}

}
