using UnityEngine;
using System.Collections;

public class WanderAnimation : MonoBehaviour {
	
	private Animator anim;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
			anim.SetInteger("Direction", 2); 
		} else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
			anim.SetInteger("Direction", 3); 
		} else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
			anim.SetInteger("Direction", 0); 
		} else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
			anim.SetInteger("Direction", 1); 
		} else {
			anim.SetInteger("Direction", -1); 
		}
	}
}
