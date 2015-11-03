using UnityEngine;
using System.Collections;

//GameOver page when the ball is destroyed
public class GameOver : MonoBehaviour {
	
	public GUISkin skin; //skin for button styles
	public static int start; //static integer indicates to show or hide Start/GameOver page
	public static bool running; //static variable indicates if the ball is destroyed or not
	
	void OnGUI(){
				GUI.skin = skin;
		        
				//if start is not equal to 0 and running is false then show GameOver page buttons
				if ((StartButton.start != 0) && !BallMovement.running) {
			if (GUI.Button (new Rect (Screen.width / 2.378f, Screen.height / 1.34f, Screen.width / 6f, Screen.height / 10.10f), "", skin.GetStyle ("Restart"))) {
								RandomPlatforms.platforms = 1;  
								Application.LoadLevel (0);  
								BallMovement.running = true;
						}
			if (GUI.Button (new Rect (Screen.width / 1.50f, Screen.height / 1.34f, Screen.width / 6.0f, Screen.height / 10.1f), "", skin.GetStyle ("Home"))) {
								Application.LoadLevel (0);  
								RandomPlatforms.platforms = 1;
								BallMovement.running = false;
								StartButton.start = 0;
						}
			if (GUI.Button (new Rect (Screen.width / 5.7f, Screen.height / 1.34f, Screen.width / 6f, Screen.height / 10.10f), "", skin.GetStyle ("Website"))) {
								Application.OpenURL ("your website here");
						}
		
				}
		}
}
