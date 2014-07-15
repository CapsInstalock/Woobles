// Animations for the shark, similar to "FishAnims" script
using UnityEngine;
using System.Collections;

public class SharkAnims : MonoBehaviour {
	public enum anim {None, IdleLeft, EatLeft, IdleRight, EatRight}
	
	OTAnimatingSprite mySprite;
	anim currentAnim;
	
	public GameObject Shark;
	
	private Shark shark;
	
	// Use this for initialization
	void Start () {
		mySprite = GetComponent<OTAnimatingSprite>();
		shark = this.gameObject.GetComponent<Shark>();
	}
	
	// Update is called once per frame
	void Update () {
		// Turn Left
		if(shark.isLeft && shark.idle && !shark.swim && currentAnim != anim.IdleLeft) {
			currentAnim = anim.IdleLeft;
			mySprite.Play("idleleft");
		}
		if(!shark.isLeft && shark.idle && !shark.swim && currentAnim != anim.IdleRight) {
			currentAnim = anim.IdleRight;
			mySprite.Play("idleright");
		}
		if(shark.isLeft && !shark.idle && shark.swim && currentAnim != anim.EatLeft) {
			currentAnim = anim.EatLeft;
			mySprite.Play("eatleft");
		}
		if(!shark.isLeft && !shark.idle && shark.swim && currentAnim != anim.EatRight) {
			currentAnim = anim.EatRight;
			mySprite.Play("eatright");
		}
	}
}
