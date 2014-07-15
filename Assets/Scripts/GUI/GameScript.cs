// For the level manager
using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {
	
	public int lastLevelPlayed;
	
	void Awake () {
		// Keep this object in all scenes after the title screen
		DontDestroyOnLoad(transform.gameObject);
	}
}
