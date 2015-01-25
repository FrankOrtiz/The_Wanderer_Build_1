using UnityEngine;
using System.Collections;

public class TrigScript : MonoBehaviour {
	
	void OnTriggerEnter2D(Collider2D other){

		Destroy (GameObject.Find("cat"));
		//Some other things happen.
	}
}