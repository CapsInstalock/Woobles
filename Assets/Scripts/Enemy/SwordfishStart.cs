// Trigger object to start the swordfish
using UnityEngine;
using System.Collections;

public class SwordfishStart : MonoBehaviour {
	
	public GameObject SwordfishObject;
	private Swordfish sword;
	
	// Use this for initialization
	void Start () {
		// Find the swordfish
		sword = SwordfishObject.GetComponent<Swordfish>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnTriggerEnter (Collider other) {
		// If object trigger is touched by the jellyfish, start the swordfish
		if (other.gameObject.CompareTag ("Player")) {
			sword.move = true;
		}
	}
}
