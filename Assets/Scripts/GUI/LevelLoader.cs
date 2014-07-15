// Loads the current level into the GameManager
using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour {
	
	public GameScript manager;
	public int levelValue;
	
	// Use this for initialization
	void Start () {
		// Find the GameManager object
		manager = GameObject.Find ("GameManager").GetComponent<GameScript>();
		// Write the current level in the GameManager
		manager.lastLevelPlayed = levelValue;
	}
}
