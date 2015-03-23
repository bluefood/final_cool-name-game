using UnityEngine;
using System.Collections;

public class laz : MonoBehaviour {

	public LineRenderer line;       
	public float pewness;
	Renderer mat;

	
	GameObject jizz;               // cube gameObject 
	jizzScript jscript;				// vubes control script
	AudioSource frySound;							//audio source and clip
	public AudioClip meow;
	bool beingHit = false;           //hit boolean
	public Light owLight;			// light for hit effect
	public GameObject player;		//ref to player
	public bool firing ;			//isFiring Bool



	void Start () 
	{
		//owLight = GetComponent<Light>();
		line = gameObject.GetComponent<LineRenderer> ();          // line renderer
		//gameScript = GetComponent<Game>();						//gettting script component
		line.enabled = false;
		Cursor.lockState=CursorLockMode.Locked;                     //lock to centre of screen 
		Cursor.visible=false;                                       //hide cursor
		owLight.gameObject.SetActive(false);
		firing = false;

	}
	
	void Update () 
		{
				if (firing==true) 
				{
						StopCoroutine ("FireLaser");
						StartCoroutine ("FireLaser");        //start co-rooutine
					
				}
				
		}

		IEnumerator FireLaser()              // enum to handle firing 
		{
			line.enabled=true;

			while(firing==true)   // while firing is set to true , set in Enemy

			{
				//target=GameObject.FindGameObjectsWithTag("nme");
			Ray ray = new Ray(transform.position,transform.forward);// creating a Ray and a hit
			RaycastHit hit;                                             
				
				line.SetPosition(0,ray.origin);         //set origin of line renderer to ray begining

			if(Physics.Raycast(ray, out hit))           
			{

				line.SetPosition(1,transform.forward);   //set end of line to transform.forward
				jizz=GameObject.CreatePrimitive(PrimitiveType.Cube);     //create cube on impact called jizz
				mat=GetComponent<Renderer>();                       //get renderer component 
				mat.material.color=Color.blue;
				//transform.localScale=Vector3.one*4;
				//Game.balls++;										//ball count not implemented
				jizz.AddComponent<Rigidbody>();
				jizz.AddComponent<jizzScript>();                    //add particle control script 

				jizz.transform.localScale = Vector3.one*.8f;      //scaling
				jizz.transform.position = hit.point;				// positioning at ray hit.point
				Destroy(jizz,10f);
			}

				if(hit.rigidbody&& beingHit==false)                    //.gameObject.tag==("Player")
			{
				beingHit=true;
				hit.rigidbody.AddForceAtPosition(transform.up*pewness ,hit.point );        //explosive force on impact
				//Debug.Log("hitting you");
				
				
				//Debug.Log(gameScript.playerHP);
																				//not implemented
				
				
				
				frySound=GetComponent<AudioSource>();    //play audio
				if(frySound)
				frySound.PlayOneShot(meow);					
				
				owLight = player.GetComponent<Light>();          // get light component
				owLight.enabled=(true);							//red light whilst hit
				//}

			}

			else
				{ 
					line.SetPosition(1,ray.GetPoint(500));        //aim at inf if no hit
					beingHit=false;   
					owLight.enabled=(false);                     //swich light when it stops hitting you
					firing=false;								//set firing boolenan
				}

				yield return null;                 //enumetrators null return

			}
				line.enabled=false;

		}
}
