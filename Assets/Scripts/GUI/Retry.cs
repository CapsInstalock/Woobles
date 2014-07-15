// The try again button
using UnityEngine;
using System.Collections;

public class Retry : MonoBehaviour {
	
	public GameScript load;
	
	// Use this for initialization
	void Start () {
		// Find the Game Manager object
		load = GameObject.Find ("GameManager").GetComponent<GameScript>();
	}
	
	void OnMouseDown () {
		// Load the last level loaded by LevelLoader
		Application.LoadLevel(load.lastLevelPlayed);
	}
}
