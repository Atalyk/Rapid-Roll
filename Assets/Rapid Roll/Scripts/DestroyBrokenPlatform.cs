using UnityEngine;
using System.Collections;

//the script will destroy pieces of the Broken platform
public class DestroyBrokenPlatform : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D collider){
		if (collider.tag == "Ball") {
			//destroy gameObject after 13 seconds
			Destroy(this.gameObject, 13f);
		}
	}
}
