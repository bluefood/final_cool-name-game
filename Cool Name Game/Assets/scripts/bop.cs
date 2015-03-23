using UnityEngine;
using System.Collections;

public class bop : MonoBehaviour
{
	public GameObject nme;
	//GameObject boom;
	// Use this for initialization
	void Start () 
	{
		//nme.transform.localScale =Vector3.one;
	
	}
	
	void OnTriggerEnter(Collider col)
		{	

			Debug.Log( col.gameObject);
			//nme.transform.localScale = Vector3.Lerp (nme.transform.localScale, new Vector3 (.02f,.02f, .02f), Time.deltaTime * 5);
			if(col.gameObject.tag==("Player"))
			{
			 
				//nme.boom.SetActive(true);
				col.transform.position = new Vector3(Random.Range(100, 200),0.1f,Random.Range(-65,65));
			}

		}
}
