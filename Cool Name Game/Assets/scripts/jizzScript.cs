using UnityEngine;
using System.Collections;

public class jizzScript : MonoBehaviour {

	Renderer otherRenderer;
	float time,timeUp;
	Game gamescript;
	//GameObject prefab;
	//public Vector3 nmeSpawn1;

	void Start()
	{
		//nmeSpawn1 = new Vector3(200,60,0);
		time=0;
		timeUp=20f;
		//prefab = Resources.Load("CubeGuy1") as GameObject;
		//gamescript=gameObject.AddComponent<Game>();
	}
	void OnCollisionEnter(Collision col)
	{
			otherRenderer = col.gameObject.GetComponent<Renderer>();
			if(col.gameObject.tag==("nme"))
			{
				
				//transform.localScale=Vector3.one*9;
				otherRenderer.material.color=Color.green;
				//bop bopSript = col.gameObject.GetComponent<bop>();
				//GameObject nuNme=Instantiate(prefab) as GameObject;
				//nuNme.transform.position = nmeSpawn1;
				//Destroy(col.gameObject,.5f);

				col.transform.position = new Vector3(Random.Range(100, 200),0.1f,Random.Range(-65,65));


			}

			/*if(col.gameObject.tag==("Player"))

			{
				gamescript.playerHP++;
				//Destroy(gameObject);
					
			}*/
	}
	void Update()
	{	//Debug.Log(time);
		time+=Time.deltaTime;
		if (time>timeUp)
		{
			//Game.balls--;
			
			Destroy(gameObject);
			
		}

	}
	
	
}
