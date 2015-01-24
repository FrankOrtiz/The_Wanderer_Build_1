using UnityEngine;
using System.Collections;

//Moves the familiar and has it follow the character.

public class FollowMeScript : MonoBehaviour {
	public float moveSpeed;
	public float turnSpeed;
	private Vector3 moveDirection;

	// Use this for initialization
	void Start () {
		//moveDirection = Vector3.right;
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 currentPosition = transform.position;
			
		moveSpeed = 3;
		turnSpeed = 4;
		//Gets the familiar to follow the character.
		Vector3 moveToward = GameObject.Find("wanderer").transform.position;
		moveDirection = moveToward - currentPosition;
		moveDirection.z = 0;
		moveDirection.y+=1;

	
		Vector3 target = moveDirection * moveSpeed + currentPosition;
		transform.position = Vector3.Lerp (currentPosition, target, Time.deltaTime);
		
		float targetAngle = Mathf.Atan2 (moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
		transform.rotation =
			Quaternion.Slerp (transform.rotation, Quaternion.Euler (0, 0, targetAngle),turnSpeed * Time.deltaTime);
	}
}