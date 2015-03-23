using UnityEngine;
using System.Collections;

public class crozzy : MonoBehaviour {

	Rect crozzyRect;
	Texture crozzyText;

	// Use this for initialization
	void Start () {
	crozzyText = Resources.Load("Textures/crozzy") as Texture; 
	crozzyRect=new Rect(Screen.width/2-256/2,
		Screen.height /2 - 256/2,
		252,252) ;
	}
	
		void OnGUI()
		{
			GUI.DrawTexture(crozzyRect,crozzyText);

		}
}
