using UnityEngine;
using System.Collections;

public class JumpTrigger : MonoBehaviour {

	public int currCharSize;
	
	void Start () {
//		currCharSize = GetComponent<Growing> ().charSize;
	}
	
	void OnTriggerExit2D( Collider2D other ) {

		CatJump jumpScript = other.gameObject.GetComponentInChildren<CatJump> ();
//		print ("I'm triggering!");
		print (other.gameObject);

		if (other.GetComponent<Growing>() != null) {

			currCharSize = other.GetComponent<Growing> ().charSize;
//			print ("Current char size is " + currCharSize);

			if (currCharSize == 1) {
//				print ("I'm jumping 1 square");
				jumpScript.SendMessage ("Jump", 1);
			}

			if (currCharSize == 2) {
//				print ("I'm jumping 2 squares");

				jumpScript.SendMessage ("Jump", 2);
			}

			if (currCharSize == 3) {
//				print ("I'm jumping 3 squares");

				jumpScript.SendMessage ("Jump", 3);
			}
		}

	}

}
