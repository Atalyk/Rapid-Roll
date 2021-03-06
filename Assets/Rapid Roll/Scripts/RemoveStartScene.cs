﻿using UnityEngine;
using System.Collections;

//Remove Start Page
public class RemoveStartScene : MonoBehaviour {

	public static bool running; //static boolean variable indicates if the ball is destroyed or not
	public static int start; //static integer indicates if Start/GameOver page is active
	
	void Update () {

		//if start is equal 0 or running is false then Start page is active
		if ((StartButton.start == 0)|| !BallMovement.running) {
			this.transform.GetChild (0).gameObject.SetActive (true);
		}
		//if start is not equal 0 or running is true then Start page is not active
		if ((StartButton.start != 0)|| BallMovement.running) {
			this.transform.GetChild (0).gameObject.SetActive (false);
		}
	
	}
}
