using UnityEngine;
using System.Collections;

//the script will mute a sound
public class SoundMute : MonoBehaviour {

	public static int mute; //static integer to mute sound

	void Update(){

		if (StartButton.mute == 0) {
			audio.mute = true;	
		}
		if (StartButton.mute == 1) {
			audio.mute = false;	
		}

	}
}
