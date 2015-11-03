using UnityEngine;
using System.Collections;

//the script indicate score and highscore
public class Score : MonoBehaviour {

	public static int highScore = 0; //static variable the highes score
	public static float sceneTimer; //sceneTimer to calculate a score
	public static bool running; //static boolean variable indicates if the ball is destroyed or not

	void Start() {
		sceneTimer = 0;
		//PlayerPrefs will store the highScore
		highScore = PlayerPrefs.GetInt("highScore", 0);
	}
	
	void OnDestroy() {
		//Sets the value of the preference identified by highScore
		PlayerPrefs.SetInt("highScore", highScore);
	}

	void Update () {

		//adapt text sizes for different values of the score
		if((int)sceneTimer>9){
			Vector3 position = this.transform.position;
			position.x = 0.37f;
			this.transform.position = position;
		}
		if((int)sceneTimer>99){
			Vector3 position = this.transform.position;
			position.x = 0.31f;
			this.transform.position = position;
		}
		//calculate the score by incrementing it each second
		if (BallMovement.running) {
			sceneTimer += Time.deltaTime;
		}
		//find highScore
		if ((int)sceneTimer > highScore) {
			highScore = (int)sceneTimer;
		}
		
		guiText.fontSize = Screen.height / 13;
		guiText.text = "" + (int)sceneTimer;
	}
}
