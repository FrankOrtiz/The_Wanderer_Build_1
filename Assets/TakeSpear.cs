using UnityEngine;
using System.Collections;

public class TakeSpear : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){
		
		MovingScript.hasSpear = true;
		Destroy (GameObject.Find("Spear"));
		//Some other things happen.
	}
}
