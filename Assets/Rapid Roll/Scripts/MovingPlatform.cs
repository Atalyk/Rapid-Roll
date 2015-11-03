using UnityEngine;
using System.Collections;

//the script indicates a direction for MovingPlatform 
public class MovingPlatform : MonoBehaviour {

	public bool Collided = false; // boolean variable indicating if MovingPlatform collided RightWall/LeftWall
	public static bool RightWall = false; //the platform collided RightWall
	public static bool LeftWall = false; //the platform collided LeftWall


	void Update(){

		//if the platform did not collide any collider then move to the right
		//you can give there any direction using random variable
		if (!Collided) {
						Vector3 position = this.transform.position;
						position.x = position.x + 0.030f;
						this.transform.position = position;
		}

		if (Collided)  {

		//if the platform collided with RightWall then it will start to move left
		if(RightWall){
						Vector3 position = this.transform.position;
						position.x = position.x - 0.030f;
						this.transform.position= position;
		}
			//if the platform collided with LeftWall then it will start to move right
		if(LeftWall){
						Vector3 position = this.transform.position;
						position.x = position.x + 0.03f;
						this.transform.position = position;
			}
		}
	}

	void OnTriggerEnter2D(Collider2D collider){

		//the platform collided with LeftWall
		if (collider.tag == "LeftWall") {
			Collided = true;
			LeftWall = true;
			RightWall = false;
		}
		//the platform collided with RightWall
		if (collider.tag == "RightWall") {
			Collided = true;
			LeftWall = false;
			RightWall = true;
		}
	}

}
