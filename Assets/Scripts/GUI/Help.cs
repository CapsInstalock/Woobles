// For the help button
using UnityEngine;
using System.Collections;

public class Help : MonoBehaviour {
	
	// Declare the screens and buttons
	public GUITexture PlayButton;
	public GUITexture Title;
	
	public GUITexture Instruct1;
	public GUITexture InstructButton;
	
	// OnMouseDown is called when object is clicked
	void OnMouseDown () {
		guiTexture.enabled = false; // Hide this button
		Title.enabled = false; // Hide the Woobles logo
		PlayButton.enabled = false; // Hide the play button
		Instruct1.enabled = true; // Show the first instruction screen
		InstructButton.enabled = true; // Show the next button
	}
}
