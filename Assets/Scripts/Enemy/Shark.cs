// For Shark Enemy
using UnityEngine;
using System.Collections;

public class Shark : MonoBehaviour {
	
	public bool idle;
	public bool swim;
	public bool isLeft;
	
	public Transform target;
	
	// Use this for initialization
	void Start () {
		//Get the target Jellyfish
        GameObject jelly = GameObject.FindGameObjectWithTag("Player");
        target = jelly.transform;
	}
	
	// Update is called once per frame
	void Update () {
		// Goes left if isLeft variable is true, otherwise, swim right
		if (isLeft)
			transform.Translate (Vector3.left);
		else
			transform.Translate (Vector3.right);
		
		// If Jellyfish is near, start eating animation
		if (Vector3.Distance(target.position, transform.position) < 80f)	{
			swim = true;
			idle = false;
		}
		else {
			idle = true;
			swim = false;
		}
	}
	
	// If the Shark hits a trigger object tagged "SharkB", set isLeft to false, if "SharkA", set to true
	void OnTriggerEnter (Collider point) {
		if (point.gameObject.CompareTag ("SharkA")) {
			isLeft = false;
		}
		if (point.gameObject.CompareTag ("SharkB")) {
			isLeft = true;
		}
	}
}
