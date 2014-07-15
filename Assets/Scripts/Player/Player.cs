using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	
	public float Turn;
	public float thrustSpeed;
	public float rotateSpeed;
	
	public GameObject powerMeter;
	
	private float totalTime; 
	public bool isHurt;
	
	private Movement movement;
	
	void Awake () {
		//totalTime = 0
		movement = GameObject.Find ("powerMeter").GetComponent<Movement>();
	}
	
	// Use this for initialization
	void Start () {
		Turn = 10f;
		thrustSpeed = 400f;
		rotateSpeed = 500f;
	}
	
	// Update is called once per frame
	void Update () {
		// Rotates if player has not hit a wall
		if (!isHurt) {
			
			// these are false unless one of keys is pressed
			movement.isLeft = false;
			movement.isRight = false;
			
				
			//Rotation Input
			if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) {
				movement.isLeft = true;
			}
			if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) {
				movement.isRight = true;
			}
		}
		else {
			print ("Player is hurt");
			// Enable Time
			totalTime += Time.deltaTime;
			// Start rotation again
			if(totalTime >= 1.5f) {
				isHurt = false;
				totalTime = 0;
			}
		}
	}
	
	void OnCollisionEnter (Collision other) {
		// Jellyfish is hurt if it collides with wall
		if (other.gameObject.CompareTag ("Wall")) {
			isHurt = true;
		}
		// Load Game Over screen if hit by swordfish
		if (other.gameObject.CompareTag ("Swordfish")) {
			Application.LoadLevel ("gover");
		}
	}
	
	void OnTriggerEnter (Collider other) {
		// Load Goal screen if end is reached
		if (other.gameObject.CompareTag ("Goal")) {
			Application.LoadLevel("goal");
		}
		
		// Load Game Over screen if hit by enemy (except Swordfish)
		if (other.gameObject.CompareTag ("Enemy")) {
			Application.LoadLevel ("gover");
		}
	}
}
