using UnityEngine;
using System.Collections;

public class JumpTrigger : MonoBehaviour {

	// testing on trigger enter for use with newly scaled rooms and physics interaction
	void OnTriggerEnter2D( Collider2D other ) {

		if (other.gameObject.tag == "Player") {

			other.gameObject.GetComponentInParent<PlayerCharacter> ().Jump ();

		}
	}

	// on trigger exit was used when jump was done through animation, might come back 
	// following tests with physics and on trigger enter
//	void OnTriggerExit2D( Collider2D other ) {
//
//		if (other.gameObject.tag == "Player") {
//
//			other.gameObject.GetComponentInParent<PlayerCharacter> ().Jump ();
//
//		}
//	}

}
