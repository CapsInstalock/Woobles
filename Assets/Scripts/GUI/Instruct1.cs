// For the next button on the first instruction screen
using UnityEngine;
using System.Collections;

public class Instruct1 : MonoBehaviour {
	
	public GUITexture Board;
	public GUITexture Instruct2;
	public GUITexture InstructButton;
	
	// OnMouseDown is called when object is clicked
	void OnMouseDown () {
		guiTexture.enabled = false; // Hide this button
		Board.enabled = false; // Hide the first instruction screen
		Instruct2.enabled = true; // Show the 2nd instruction screen
		InstructButton.enabled = true; // Show the back button
	}
}
