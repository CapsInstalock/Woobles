using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	
	public float fullWidth = 256f; // max width of the powerbar
	public float thePower; // current power
	
	public bool increasing = false;
	public bool thrust = false;
	
	public float barSpeed = 25f; // how fast the bar will fill
	
	private GameObject player; // the player gameobject
	public float rotateSpeed;
	public float thrustTime;
	
	public bool isLeft;
	public bool isRight;
	
	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}
	
	// Update is called once per frame
	void Update () {
		
		
		if(!thrust) {
			// If jump is held down set increasing to true
			if(Input.GetButton("Jump")) {
				increasing = true;
			}
			else if (Input.GetButtonUp ("Jump")) {
				player.rigidbody.AddRelativeForce (Vector3.up * thePower * 30);
				increasing = false;
				thrust = true;
			}
			
			if(!increasing) {
				if(isLeft) {
					player.transform.Rotate(Vector3.forward * rotateSpeed * Time.deltaTime);
				}
				if(isRight) {
					player.transform.Rotate(-Vector3.forward * rotateSpeed * Time.deltaTime);
				}
			}
		}
		
		Rect pos = guiTexture.pixelInset;
		pos.xMax = guiTexture.pixelInset.xMin + fullWidth * thePower / fullWidth;
		guiTexture.pixelInset = pos;
		
		if(increasing) {
			thePower += Time.deltaTime * barSpeed;
			thePower = Mathf.Clamp (thePower, 0, fullWidth);
		}
		else {
			thePower = 0;
		}
		
		if(thrust) {
			// Enable Time
			thrustTime += Time.deltaTime;
			Debug.Log ("current time:" + thrustTime);
			// Start thrust again
			if(thrustTime >= 1.5f) {
				thrust = false;
				thrustTime = 0;
			}
		}
	}
}
