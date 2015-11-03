using UnityEngine;
using System.Collections;

public class AllTextSizes : MonoBehaviour {

	//All text sizes for different GUI texts
	
	void Update () {

		//change the size of guitext with tag "GameOver"
		//GameOver text appears when ball is destroyed
		if (guiText.tag == "GameOver") {
			guiText.fontSize = Screen.height / 7;
		}
		//change the size of guitext with tag "RapidRoll"
		//this is title text
		if (guiText.tag == "RapidRoll") {
			guiText.fontSize = Screen.height / 6;
		}
		//change the size of guitext with tag "Tap"
		//Tap to play text size
		if (guiText.tag == "Tap") {
			guiText.fontSize = Screen.height / 17;		
		}
		//Press the sides of the screen text
		if (guiText.tag == "Tap") {
			guiText.fontSize = Screen.height / 25;		
		}
		//change the size of guitext with tag "Sides"
		//Left and Right texts size
		if (guiText.tag == "Sides") {
			guiText.fontSize = Screen.height / 13;		
		}
	}
}
