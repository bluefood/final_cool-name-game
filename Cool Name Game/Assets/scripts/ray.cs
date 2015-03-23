using UnityEngine;
using System.Collections;

public class ray : MonoBehaviour {
	void Update() {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Physics.Raycast(ray, out hit, 100))
			Debug.DrawLine(ray.origin, hit.point);
		
	}
}
