// For comic screen
using UnityEngine;
using System.Collections;

public class Comic : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		// Pressing space loads the first level
		if(Input.GetKeyDown(KeyCode.Space)) {
			Application.LoadLevel("level1");
		}
	}
}
