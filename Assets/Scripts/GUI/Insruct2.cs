// For the back button on the 2nd instruction screen
using UnityEngine;
using System.Collections;

public class Insruct2 : MonoBehaviour {
	
	public GUITexture PlayButton;
	public GUITexture Title;
	public GUITexture HelpButton;
	
	public GUITexture Board;
	
	// OnMouseDown is called when object is clicked
	void OnMouseDown () {
		guiTexture.enabled = false; // Hide this button
		Board.enabled = false; // Hide the 2nd instruction screen
		Title.enabled = true; // Show the Woobles title
		PlayButton.enabled = true; // Show the play button
		HelpButton.enabled = true; // Show the help button
	}
}
