// For the swordfish
using UnityEngine;
using System.Collections;

public class Swordfish : MonoBehaviour {
	
	public bool move;
	public float moveForce;
	
	private float totalTime;
	public float maxTime;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (move) {
			// Start moving forward
			rigidbody.AddRelativeForce (Vector3.left * moveForce * 25);
			totalTime += Time.deltaTime;
			// If set time is reached, stop moving
			if(totalTime >= maxTime) {
				move = false;
			}
		}
	}
}
