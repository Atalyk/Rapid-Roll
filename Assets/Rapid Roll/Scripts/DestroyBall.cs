using UnityEngine;
using System.Collections;

//the script aims to destroy the ball
public class DestroyBall : MonoBehaviour {
	
	public Transform BallParticles; //Pieces of the ball
	public static bool running; //static boolean indicates if the ball is destroyed or not
	public static int start; //indicates if start page is active or not

	void OnTriggerEnter2D(Collider2D collider){

		//if ball will collide with GameObject "DestroyBall" or "Thorns"
		if (collider.tag == "DestroyBall"||collider.tag == "Thorns") {

			//Instantiate BallParticles in this position
			Instantiate(BallParticles, new Vector3 (this.transform.position.x, this.transform.position.y, 0), Quaternion.identity);
			//Ball sprite renderer is false (hidden)
			Destroy(gameObject);
			//Increment static integer
			StartButton.start++; 
			//Ball is destroyed
			BallMovement.running = false;
		}
	}
}
