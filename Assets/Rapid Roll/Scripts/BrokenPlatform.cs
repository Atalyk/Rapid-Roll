using UnityEngine;
using System.Collections;

//destroy BrokenPlatform (Green) if collide with the ball
public class BrokenPlatform : MonoBehaviour {

	public Transform Broken;//Broken pieces of the platform

	//if Broken platform will collide with the ball
	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Ball") {
			//Broken platform (gameObject) will be destroyed
			Destroy(this.gameObject);
			//There will be instantiated broken pieces of this platform
			Instantiate (Broken, new Vector3 (this.transform.position.x, this.transform.position.y, 0), Quaternion.identity);
		}
	}
}
