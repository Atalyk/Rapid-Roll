using UnityEngine;
using System.Collections;

//the script will show the best score in GameOver page
public class MyBest : MonoBehaviour {

	public static int highScore; // static integer variable (originally in script #Score)

	void Update () {

		//guiText will show the best score
		guiText.text = "" + Score.highScore;
		guiText.fontSize = Screen.height / 11;
	}
	
}
