//using UnityEngine;
//using System.Collections;
//
//public class WandererHealth : MonoBehaviour
//{
//	public float health = 100f;                         // How much health the player has left.                     // The sound effect of the player dying.	
//	public HealthScript playerHealth = this.GetComponent<HealthScript>();
//	private bool playerDead;                            // A bool to show if the player is dead or not.
//	
//	
//	void Update ()
//	{
//		// If health is less than or equal to 0...
//		if(health <= 0f)
//		{
//			// ... and if the player is not yet dead...
//			if(!playerDead){
//				// ... call the PlayerDying function.
//				Debug.Log("Player Dying");
//			}
//			else
//			{
//				// Otherwise, if the player is dead, call the PlayerDead and LevelReset functions.
//				Debug.Log("Player Dead");
//			}
//		}
//	}
//}