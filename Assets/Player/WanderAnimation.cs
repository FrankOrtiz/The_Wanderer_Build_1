using UnityEngine;
using System.Collections;

public class WanderAnimation : MonoBehaviour {

	public Sprite[] idle;
	public Sprite[] movement;

	public float framesPerSecond;
	
	private SpriteRenderer spriteRenderer;
	private Animator anim;
	
	// Use this for initialization
	void Start () {
		spriteRenderer = renderer as SpriteRenderer;
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A) || 
		    Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W) || 
		    Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || 
		    Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)) {
			anim.SetBool("Change", true); 
		} else {
			anim.SetBool("Change", false); 
		}
	}
}
