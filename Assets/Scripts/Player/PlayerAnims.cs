// Animation for the jellyfish
using UnityEngine;
using System.Collections;

public class PlayerAnims : MonoBehaviour {
	public enum anim {None, idle, hurt, moveleft, moveright, poweridle, powerthrust, thrust}
	
	OTAnimatingSprite mySprite;
	anim currentAnim;
	public GameObject powerMeter;
	public GameObject player;
	
	private Player jelly;
	private Movement movement;
	
	// Use this for initialization
	void Start () {
		mySprite = GetComponent<OTAnimatingSprite>();
		jelly = player.GetComponent<Player>();
		movement = GameObject.Find ("powerMeter").GetComponent<Movement>();
	}
	
	// Update is called once per frame
	void Update () {
		// Turn Left
		if(movement.isLeft && !jelly.isHurt && !movement.thrust && !movement.increasing && currentAnim != anim.moveleft) {
			currentAnim = anim.moveleft;
			mySprite.Play("moveleft");
		}
		// Turn Right
		if(movement.isRight && !jelly.isHurt && !movement.thrust && !movement.increasing && currentAnim != anim.moveleft) {
			currentAnim = anim.moveright;
			mySprite.Play("moveright");
		}
		// Is Increasing
		if(!movement.isLeft && !movement.isRight && !jelly.isHurt && movement.increasing && !movement.thrust && currentAnim != anim.thrust) {
			currentAnim = anim.thrust;
			mySprite.Play("thrust");
		}
		// Is Hurt
		if(jelly.isHurt && currentAnim != anim.hurt) {
			currentAnim = anim.hurt;
			mySprite.Play("hurt");
		}
		// Reset Animation
		if(!movement.isLeft && !movement.isRight && !movement.increasing && !jelly.isHurt && currentAnim != anim.idle) {
			currentAnim = anim.idle;
			mySprite.Play("idle");
		}
	}
}
