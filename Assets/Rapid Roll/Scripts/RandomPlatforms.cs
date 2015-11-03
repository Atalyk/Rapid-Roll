using UnityEngine;
using System.Collections;

//the script will instantiate randomly platforms
public class RandomPlatforms : MonoBehaviour {

	public Transform Platform;//Regular Platform
	public Transform BrokenPlatform;//Broken Platform
	public Transform DisPlatform;//Disappearing Platform
	public Transform MovingPlatform; // Moving Platform
	public Transform Thorns; // Thorns
	public float InstantiateX; //Instatiate randomly platforms respectively to x axis
	public float InstantiateY; //Instatiate platforms respectively to y axis 
	public int randPlatform; // Random variable
	private float timer; //timer for frequency of the instantiation
	public static bool running; //static boolean variable indicates if the ball is destroyed or not
	public static int platforms = 1;

	void Update() {
	
		//if the ball is not destroyed
		if (BallMovement.running) {
						if (platforms < 15) {

								timer -= Time.deltaTime;

								if (timer < 0) {
					                    
										platforms++;
										//use randomly variable between 0 and 8 
										randPlatform = Random.Range (0, 8);
										//between x positions -2.5f and 2.5f
										InstantiateX = Random.Range (-2.5f, 2.5f);
										//every y-0.8 position
										InstantiateY = InstantiateY - 0.8f;

										if (randPlatform == 0) {
												Instantiate (Platform, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										if (randPlatform == 1) {
												Instantiate (BrokenPlatform, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										if (randPlatform == 2) {
												Instantiate (DisPlatform, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										if (randPlatform == 3) {
												Instantiate (Thorns, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										if (randPlatform == 4) {
												Instantiate (Platform, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										if (randPlatform == 5) {
												Instantiate (Platform, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										if (randPlatform == 6) {
												Instantiate (Platform, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}
										if (randPlatform == 7) {
												Instantiate (MovingPlatform, new Vector3 (InstantiateX, InstantiateY, 0), Quaternion.identity);
										}

										timer = Random.Range (0.6f, 0.65f);	
										
								}

						}
				}
	}
}