using UnityEngine;
using System.Collections;

//the script for Start page
public class StartButton : MonoBehaviour {
	
	public GUISkin skin;
	public static int mute = 1; //initially the sound is not mute
	public static bool running; //static boolean variable indicates if the ball is destroyed or not
	public static int start = 0; //static integer indicates if Start/GameOver page is active
	
	void OnGUI(){
				GUI.depth = 1;
				GUI.skin = skin;
	
		        //if Start page is active
				if (start == 0 && !BallMovement.running) {
						//change the button style
						if (mute == 1 && GUI.Button (new Rect (Screen.width / 1.50f, Screen.height / 1.34f, Screen.width / 6.0f, Screen.height / 10.1f), "", skin.GetStyle ("On"))) {
								if (mute == 1)
										mute = 0;
						}
						//change button style
			if (mute == 0 && GUI.Button (new Rect (Screen.width / 1.5f, Screen.height / 1.34f, Screen.width / 6.0f, Screen.height / 10.1f), "", skin.GetStyle ("Off"))) {
								if (mute == 0)
										mute = 1;
			
						}
			if (GUI.Button (new Rect (Screen.width / 5.7f, Screen.height / 1.34f, Screen.width / 6f, Screen.height / 10.10f), "", skin.GetStyle ("Website"))) {
								Application.OpenURL ("your website here");
						
				}
			if (GUI.Button (new Rect (Screen.width / 3f, Screen.height / 2.1f, Screen.width / 3f, Screen.height / 5f), "", skin.GetStyle ("Play"))) {
				BallMovement.running = true;
				
			}
			    //to show the highest score
			if (GUI.Button (new Rect (Screen.width / 2.378f, Screen.height / 1.34f, Screen.width / 6f, Screen.height / 10.10f), "", skin.GetStyle ("Star"))) {
					start++;
				}
	}
		}
}
