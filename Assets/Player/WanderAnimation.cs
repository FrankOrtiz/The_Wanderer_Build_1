using UnityEngine;
using System.Collections;

public class WanderAnimation : MonoBehaviour {
	
	private Animator anim;
	public int frame;
	public bool canMoonWalk;
	
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
		frame = 0;
	}

	void playstep(int frame){
		if (frame == 13) {
			audio.Play();
		}
	}
	
	// Update is called once per frame
	void Update () {
		canMoonWalk = MovingScript.canMoonWalk;
		frame = (frame % 30) + 1;
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) {
			anim.SetInteger("Direction", 2);
			if(canMoonWalk==true){
				anim.SetBool("CanMoonWalk",true);
			}
			playstep(frame);
		} else if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) {
			anim.SetInteger("Direction", 3); 
			anim.SetBool("CanMoonWalk",false);
			playstep(frame);
		} else if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) {
			anim.SetInteger("Direction", 0);
			if(canMoonWalk == true){
				anim.SetBool("CanMoonWalk",true);
			playstep(frame);
			}
		} else if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
			anim.SetInteger("Direction", 1); 
			anim.SetBool("CanMoonWalk",false);
			playstep(frame);
		} else {
			anim.SetInteger("Direction", -1); 
		}
	}
}
