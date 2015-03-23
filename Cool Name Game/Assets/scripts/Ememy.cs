using UnityEngine;
using System.Collections;

public class Ememy : MonoBehaviour {

	enum GameState {idle,irritated,irate,irrelevant,fallen}    // game state enumerators

	GameState currentState;
	public GameObject player;
	//public GameObject eye;             //checking for toppling
	float dist=10f;
	Renderer renderer;
	laz lazerScript;

	// Use this for initialization
	void Start () 
		{
			currentState=GameState.idle;
			renderer = gameObject.GetComponent<Renderer>();
			lazerScript = gameObject.GetComponent<laz>();
		}
	
	// Update is called once per frame
	void Update () 
		{
				dist =Vector3.Distance(this.transform.position, player.transform.position);

			switch(currentState)
				{
				case GameState.idle:
				renderer.material.color = Color.black;
				//transform.Rotate(new Vector3 (0,Time.deltaTime*55,0));	//ruined by LookAT
				
												/*if(eye.transform.position.y<2)
												{
												SetState(GameState.fallen);	
												}*/

				if(dist<10f)						//if within 10f 
				{											
					Debug.Log("getting irritated");
					SetState(GameState.irritated);
				}
				break;
				
				case GameState.irritated:  
				renderer.material.color = Color.yellow;
				lazerScript.firing=true;

				/*if(eye.transform.position.y<1)
				{
				SetState(GameState.fallen);	
				}*/

				if(dist>10f)	
				{											
					Debug.Log("getting idle");
					SetState(GameState.idle);
				}

				//aim fire rage
				// if(further abuse)
				//{
				//	SetState(GameState.irate);
				//	}
					
				break;

				case GameState.irate:
				//super rage
				// if (further abuse) die
				break;

				case GameState.fallen:
				Debug.Log("fallen over");

				transform.position = Vector3.Lerp(transform.position, Vector3.up*3, 2f);
				//transform.rotation = Quaternion.Lerp(transform.rotation,new Quaternion(0f,0f,0f,0f),2f);
				break;
			}


	
		}

	void SetState(GameState state)
		{
		currentState = state;
		}

}
