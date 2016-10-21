using UnityEngine;
using System.Collections;

public class JumpTrigger : MonoBehaviour {

	public int currCharSize;
	private float jumpForce;
//	public JumpWithPhysics jumpingScript;
	
	void Start () {
		jumpForce = 100f;
		
//		currCharSize = GetComponent<Growing> ().charSize;
	}
	
	void OnCollisionExit2D( Collision2D other ) {

//		CatJump jumpScript = other.gameObject.GetComponentInChildren<CatJump> ();
//		print ("I'm triggering!");
		print (other.gameObject);

		if (other.gameObject.GetComponent<Growing>() != null) {

			currCharSize = other.gameObject.GetComponent<Growing> ().charSize;
//			print ("Current char size is " + currCharSize);

			if (currCharSize == 1) {
//				print ("I'm jumping 1 square");
//				jumpScript.Jump (1);
				jumpForce *= 1f;
				other.gameObject.GetComponent<Rigidbody2D>().AddForce(other.transform.up * jumpForce);
			}

			if (currCharSize == 2) {
//				print ("I'm jumping 2 squares");
//				jumpScript.Jump (2);
				jumpForce *= 2f;
				other.gameObject.GetComponent<Rigidbody2D>().AddForce(other.transform.up * jumpForce);
			}

			if (currCharSize == 3) {
//				print ("I'm jumping 3 squares");
//				jumpScript.Jump (3);
				jumpForce *= 3f;
				other.gameObject.GetComponent<Rigidbody2D>().AddForce(other.transform.up * jumpForce);
			}
		}

	}

}
