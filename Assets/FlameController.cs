using UnityEngine;
using System.Collections;

public class FlameController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (MovingScript.health == 0) {
			audio.Stop ();
		}
	}
}
