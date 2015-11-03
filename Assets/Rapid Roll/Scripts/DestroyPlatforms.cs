using UnityEngine;
using System.Collections;

//destroy unrequired platforms
public class DestroyPlatforms : MonoBehaviour {

	public static int platforms;
	
	void OnTriggerEnter2D(Collider2D collider){

		//if platforms will collide Thorns 
		if (collider.tag == "Thorns") {
			//destroy them
			Destroy(this.gameObject); 
			RandomPlatforms.platforms--;
		}
	}
}
