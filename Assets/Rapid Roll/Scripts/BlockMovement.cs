using UnityEngine;
using System.Collections;

public class BlockMovement : MonoBehaviour {
	
	public static bool running;

	void Update () {

		//if running is true (ball is not destroyed) then block will move upwards
		if (BallMovement.running) {
						transform.Translate (Vector3.up * Time.deltaTime, Space.World);
				}

	}
}
