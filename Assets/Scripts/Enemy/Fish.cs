// For Fish Enemy
using UnityEngine;
using System.Collections;

public class Fish : MonoBehaviour {
	
	// States of the Fish
	public bool idle;
	public bool near;
	public bool veryNear;
	public bool isLeft, isRight;
	
	public Transform target;
	
	// Use this for initialization
	void Start () {
		//Find the Jellyfish and set it as target
        GameObject jelly = GameObject.FindGameObjectWithTag("Player");
        target = jelly.transform;
	}
	
	// Update is called once per frame
	void Update () {
		// Change state of fish based on distance to Jellyfish
		if (Vector3.Distance(target.position, transform.position) < 80f && Vector3.Distance(target.position, transform.position) > 40f)	{
			veryNear = false;
			near = true;
			idle = false;
		}
		else if (Vector3.Distance(target.position, transform.position) < 40f)	{
			veryNear = true;
			near = false;
			idle = false;
		}
		else {
			idle = true;
			near = false;
			veryNear = false;
		}
	}
}
