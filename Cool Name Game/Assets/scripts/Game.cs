using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game : MonoBehaviour {

	public Transform Player;			//player transform
	public Transform startText;		 //welcome txt
	public Transform credits;        //game over txt
	public Vector3 spawnPoint; 		//players start pos               
	//public static int balls;		// not implemented
	public int playerHP;            // not implemented
	public Text Startification;      //txt object


	enum GameState {startText,startWait,playGame,rollCredits}    // game state enumerators

	GameState currentState;

	float deltaT = 0f;   // time since last state change or since this state
	public float camSens = 14f;  // camera panning scaling

	
	void Start () 
		{
			//balls=0;
			playerHP=5000;                           // player hp and ball stamina not implemented

		Cursor.visible = false;								// cursor lock and hide
		Cursor.lockState = CursorLockMode.Locked;
		SetState(GameState.startText);               // initial Game state 
		}


	void SetState(GameState state)
		{
		currentState = state;
		deltaT=Time.time;
		}

	float timeSince()
		{ 
		return Time.time - deltaT;   //calc time since last state change
		} 
	
	// Update is called once per frame
	void Update () 
		{

			if(Player.position.y < -20f)      									 // if player falls below -20 on y
			{
				Player.transform.position=new Vector3(150,20,0);        					// reset to spawn point
				Player.GetComponent<Rigidbody>().velocity = Vector3.zero;       // zero velocity
			}

			switch(currentState)
				{
				case GameState.startText:
					//transform.Translate(Vector3.up*3.0f * Time.deltaTime );      //pan upwards *MEBE TO spawnPoints
					/*if(startGameText)
					startGameText.enabled=true;*/
					Debug.Log(timeSince());
					if(timeSince()>2.5f)
						{										//after 2.5f change to startWait
						SetState(GameState.startWait);
						Startification.text="ready...";
						}
				break;
				
				case GameState.startWait:              
					
					//startGameText.text=("ready...");
					
					if(timeSince() > 1f)                                         // wait 1.0f then change to playing

						{
						SetState(GameState.playGame);
						}
				break;

				case GameState.playGame:
					Startification.text="";

				//Quaternion targetRot = Quaternion.LookRotation(Player.position - transform.position);  //calc angle tween camera and player
				//transform.rotation = Quaternion.Lerp(transform.rotation, targetRot, Time.deltaTime);   //smooth lerp on camera at player
						
					if(Input.GetKeyDown(KeyCode.Escape)) // if game over condition go to credits
						{
							SetState(GameState.rollCredits);
						}
				break;

				case GameState.rollCredits:
				Startification.text=("game over");
				Time.timeScale=0;
				//Quaternion creditRot = Quaternion.LookRotation(credits.position - transform.position);  //calc angle tween camera and credits
				//transform.rotation = Quaternion.Lerp(transform.rotation, creditRot, Time.deltaTime);
				//transform.position = Vector3.Lerp(transform.position, Player.position, 10f);

				if(Input.GetKeyDown(KeyCode.Escape)) // if escape go to start
					{
						transform.position = new Vector3(0,0,0);
						//startGameText.enabled=false;
						Startification.text=("Startification...");
						SetState(GameState.startText);
						Time.timeScale=1;
					}


				break;


			}
		}
}
