using UnityEngine;
using System.Collections;

//the script to teleport the ball from one side to another
public class TeleportBall : MonoBehaviour {



	void OnTriggerEnter2D(Collider2D collider){
		//if the ball is collided with RightWall then teleport it to the left
		if (collider.tag == "RightWall") {
			Vector3 position = this.transform.position;
			position.x = -4.0f;
			this.transform.position = position;
		}
		//if the ball is collided with LeftWall then teleport it to the right
		if (collider.tag == "LeftWall") {
			Vector3 position = this.transform.position;
			position.x = 4.0f;
			this.transform.position = position;
		}
		if (collider.tag == "Thorns") {
			Destroy(this.gameObject, 0.5f);
		}
	}
}
