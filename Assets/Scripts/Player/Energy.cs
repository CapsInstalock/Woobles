// The players energy meter
using UnityEngine;
using System.Collections;

public class Energy : MonoBehaviour {
	
	public float fullWidth = 256f; // max width of the powerbar
	public float theTime; // The time before the player could move again
	
	public GameObject powerMeter; // Finds the powermeter
	
	private Movement barTime; // Gets the players movement script
	
	// Use this for initialization
	void Start () {
		// Find the powermeter and its script
		barTime = powerMeter.GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update () {
		// If thrust variable in player is true
		if(barTime.thrust) {
			theTime += barTime.thrustTime * 3.8f;
			
			Rect pos = guiTexture.pixelInset;
			pos.xMax = guiTexture.pixelInset.xMin + fullWidth * theTime / fullWidth;
			guiTexture.pixelInset = pos;
		}
		else {
			theTime = 0; // Reset the time
		}
	}
}
