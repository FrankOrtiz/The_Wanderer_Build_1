using UnityEngine;
using System.Collections;

public class IdleWaxController : MonoBehaviour {

	public int counter;
	// Use this for initialization
	void Start () {
		counter = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (MovingScript.health == 1) {
			if (counter ==0){
			audio.Play();
				counter++;
			}
		}
	}
}
