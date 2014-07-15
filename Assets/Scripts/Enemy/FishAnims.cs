// Controls the animation of the Fish
using UnityEngine;
using System.Collections;

public class FishAnims : MonoBehaviour {
	// Declare the animations of the fish
	public enum anim {None, IdleLeft, NearLeft, EatLeft, IdleRight, NearRight, EatRight}
	
	// Create animation variables
	OTAnimatingSprite mySprite;
	anim currentAnim;
	
	public GameObject Fish;
	
	private Fish fish;
	
	// Use this for initialization
	void Start () {
		// Find the fish and get variables of it's script
		mySprite = GetComponent<OTAnimatingSprite>();
		fish = this.gameObject.GetComponent<Fish>();
	}
	
	// Update is called once per frame
	void Update () {
		// If the fish is facing left and the jellyfish is far, play an idle animation
		if(fish.isLeft && !fish.isRight && fish.idle && !fish.near && !fish.veryNear && currentAnim != anim.IdleLeft) {
			currentAnim = anim.IdleLeft;
			mySprite.Play("idleleft");
		}
		// If the fish is facing left and the jellyfish is near, play a near animation
		if(fish.isLeft && !fish.isRight && !fish.idle && fish.near && !fish.veryNear && currentAnim != anim.NearLeft) {
			currentAnim = anim.NearLeft;
			mySprite.Play("nearleft");
		}
		// If the fish is facing left and the jellyfish is very near, play an eating animation
		if(fish.isLeft && !fish.isRight && !fish.idle && !fish.near && fish.veryNear && currentAnim != anim.EatLeft) {
			currentAnim = anim.EatLeft;
			mySprite.Play("eatleft");
		}
		// Facing right, jellyfish is far
		if(!fish.isLeft && fish.isRight && fish.idle && !fish.near && !fish.veryNear && currentAnim != anim.IdleLeft) {
			currentAnim = anim.IdleRight;
			mySprite.Play("idleright");
		}
		// Facing right, jellyfish is near
		if(!fish.isLeft && fish.isRight && !fish.idle && fish.near && !fish.veryNear && currentAnim != anim.NearLeft) {
			currentAnim = anim.NearRight;
			mySprite.Play("nearright");
		}
		// Facing right, jellyfish is very near
		if(!fish.isLeft && fish.isRight && !fish.idle && !fish.near && fish.veryNear && currentAnim != anim.EatLeft) {
			currentAnim = anim.EatRight;
			mySprite.Play("eatright");
		}
	}
}
