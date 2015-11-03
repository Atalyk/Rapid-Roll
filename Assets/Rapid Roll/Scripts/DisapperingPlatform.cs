using UnityEngine;
using System.Collections;

//Destroy the platform (Orange) after collision with ball in 2 seconds
public class DisapperingPlatform : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Ball") {
			Destroy(this.gameObject, 2.0f);
		}
	}
}
