using UnityEngine;
using System.Collections;

public class Visibility : MonoBehaviour {
	public bool switcheroo;

	void update(){
		while(switcheroo = false){
			if(MovingScript.hasSpear == true){
				GameObject.Find("SpearNoRoot").layer = 3;
				switcheroo = true;
			}
		}
	}
}
