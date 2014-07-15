// For the main menu button
using UnityEngine;
using System.Collections;

public class Menu : MonoBehaviour {

	void OnMouseDown () {
		// Load title screen
		Application.LoadLevel("Title");
	}
}
