using UnityEngine;

public class StartGame : MonoBehaviour {

	private float audioVolume;
	private double delayStart;
	private double countTime;
	// Use this for initialization
	void Start () {
		audioVolume = 0;
		audio.Play ();
		countTime = 0;
		delayStart = 20;
	}
	
	void Update() {

		if (Input.anyKeyDown) {
			if (countTime ==0){
				delayStart = Time.time;
				countTime ++;
			}
			fadeOut();
		}

		if (Time.time - delayStart > 1) {
				Application.LoadLevel ("Room1");
			}

		fadeIn ();
	}

	void fadeIn() {
		if (audioVolume < 1) {
			audioVolume += (float) 0.1 * Time.deltaTime;
			audio.volume = (float) audioVolume;
		}
	}

   void fadeOut() {
		if(audioVolume > 0.1)
		{
			audioVolume -= (float) 0.05 * Time.deltaTime;
			audio.volume = audioVolume;
		}
	}
}