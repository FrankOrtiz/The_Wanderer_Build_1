using UnityEngine;
using System.Collections;

public class MovingScript : MonoBehaviour {
	public static int health;
	public static bool canMoonWalk;
	public static bool hasSpear;
	public static bool hasHelmet;
	public int current;
	public float timer;
	public float moveSpeed;
	public float upSpeed;
	public float leftSpeed;
	public float rightSpeed;
	public float downSpeed;
	public float turnSpeed;
	public float topSpeed;
	public float midSpeed;
	private Vector3 moveDirection;
	// Use this for initialization
	void Start () {
		canMoonWalk = true;
		topSpeed = 0.09f;
		midSpeed = 0.035f;
		moveSpeed = 0.02f;
		upSpeed = moveSpeed;
		downSpeed = moveSpeed;
		leftSpeed = moveSpeed;
		rightSpeed = moveSpeed;
		health = 308;

	}

	// Update is called once per frame
	void Update () {
		if (Time.timeSinceLevelLoad > 8) {
			Vector3 currentPosition = this.transform.position;
			if (health>100){
				Debug.Log("The Wanderer has found a light.");
			}
			if (health > 0) {

				timer += Time.deltaTime;
				if(timer > 1.0f)
				{
					timer -= 1.0f;
					health -=1;
				}

			}
			else {
				Debug.Log("Wanderer's light has faded...");
			}
			//Up input logic
			if ((Input.GetKey(KeyCode.UpArrow))||(Input.GetKey(KeyCode.W))){
				SmoothMoves();
				currentPosition.y+=upSpeed;
				downSpeed = midSpeed;
				leftSpeed = midSpeed;
				rightSpeed = midSpeed;
				canMoonWalk=false;
			}
			//Down input logic
			else if ((Input.GetKey(KeyCode.DownArrow))||(Input.GetKey(KeyCode.S))){
				SmoothMoves();
				currentPosition.y-=downSpeed;
				upSpeed = midSpeed;
				leftSpeed = midSpeed;
				rightSpeed = midSpeed;
				canMoonWalk=false;
			}
			//Left input logic
			else if ((Input.GetKey(KeyCode.LeftArrow))||(Input.GetKey(KeyCode.A))){
				SmoothMoves();
				currentPosition.x-=leftSpeed;
				upSpeed = midSpeed;
				downSpeed = midSpeed;
				rightSpeed = midSpeed;
			}
			//Right input logic
			else if ((Input.GetKey(KeyCode.RightArrow))||(Input.GetKey(KeyCode.D))){
				SmoothMoves();
				currentPosition.x+=rightSpeed;
				upSpeed = midSpeed;
				downSpeed = midSpeed;
				leftSpeed = midSpeed;
			}
			else{
				//moveSpeed=0;
				//turnSpeed=0;
			}

			//Resets/reduces the speed once a key is no longer being pressed.
			if ((Input.GetKeyUp(KeyCode.UpArrow))||(Input.GetKeyUp(KeyCode.W))){
				upSpeed=midSpeed;
				canMoonWalk=true;
			}
			else if((Input.GetKeyUp(KeyCode.DownArrow))||(Input.GetKeyUp(KeyCode.S))){
				downSpeed=midSpeed;
				canMoonWalk=true;
			}
			else if((Input.GetKeyUp(KeyCode.LeftArrow))||(Input.GetKeyUp(KeyCode.A))){
				leftSpeed=midSpeed;
			}
			else if((Input.GetKeyUp(KeyCode.RightArrow))||(Input.GetKeyUp(KeyCode.D))){
				rightSpeed=midSpeed;
			}

			//Responsible for moving the character
			Vector3 target = moveDirection * moveSpeed + currentPosition;
			transform.position = Vector3.Lerp (currentPosition, target, Time.deltaTime);
		}
		
		//float targetAngle = Mathf.Atan2 (moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
		//transform.rotation =
		//	Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 0, targetAngle),turnSpeed * Time.deltaTime);
	}

	//Makes the character movement a bit smoother.
	void SmoothMoves(){
		//Prevents the character from exceeding top speed.
		if (upSpeed>topSpeed){
			upSpeed = topSpeed;
		}
		//Second part of acceleration.
		else if((upSpeed<topSpeed) && (upSpeed>midSpeed)){
			upSpeed+=0.003f;
		}
		//First part of acceleration.
		else{
			upSpeed+=0.0015f;
		}

		if (downSpeed>topSpeed){
			downSpeed = topSpeed;
		}
		else if((downSpeed<topSpeed) && (downSpeed>midSpeed)){
			downSpeed+=0.003f;
		}
		else{
			downSpeed+=0.0015f;
		}

		if (leftSpeed>topSpeed){
			leftSpeed = topSpeed;
		}
		else if((leftSpeed<topSpeed) && (leftSpeed>midSpeed)){
			leftSpeed+=0.003f;
		}
		else{
			leftSpeed+=0.0015f;
		}

		if (rightSpeed>topSpeed){
			rightSpeed = topSpeed;
		}
		else if((rightSpeed<topSpeed) && (rightSpeed>midSpeed)){
			rightSpeed+=0.003f;
		}
		else{
			rightSpeed+=0.0015f;
		}
	}

}
