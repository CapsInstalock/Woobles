// Play Button
using UnityEngine;
using System.Collections;

public class Play : MonoBehaviour {
	
	void OnMouseDown () {
		// Loads the comic scene
		Application.LoadLevel("Comic");
	}
}
