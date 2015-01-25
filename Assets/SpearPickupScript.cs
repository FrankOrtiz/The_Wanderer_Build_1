using UnityEngine;
using System.Collections;

public class SpearPickupScript : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){

		MovingScript.hasSpear = true;
		Destroy (GameObject.Find("Spear Holder"));
		//Some other things happen.
	}
}
