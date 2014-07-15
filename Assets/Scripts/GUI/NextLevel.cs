// Loads the next level
using UnityEngine;
using System.Collections;

public class NextLevel : MonoBehaviour {
	
	public GameScript load;
	
	// Use this for initialization
	void Start () {
		// Finds the game manager object
		load = GameObject.Find ("GameManager").GetComponent<GameScript>();
	}

	void OnMouseDown () {
		// Get the last level loaded by LevelLoader and adds 1, loading the next level
		Application.LoadLevel(load.lastLevelPlayed + 1);
	}
}
