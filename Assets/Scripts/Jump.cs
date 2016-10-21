using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public Vector2 jumpForce = new Vector2(0,100);
//	Animator animator;

	// Use this for initialization
	void Start () {
//		animator = GetComponent<Animator>();
//		animator.SetInteger ("Death", 0);
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButton(0)) {
//			print(jumpForce);
			GetComponent<Rigidbody2D>().velocity = Vector2.zero;
//			if ( jumpForce.x < 150 ) {
				GetComponent<Rigidbody2D>().AddForce(jumpForce += jumpForce/100);
//			}
//			else {
//				jumpForce.x = 150;
//			}
		}
		else {
			jumpForce = new Vector2(0,100);
			Input.ResetInputAxes();
		}

		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);

		if (screenPosition.y > Screen.height || screenPosition.y < 0) {
			Die();
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {
		if (coll.gameObject.tag == "playerKiller") {
			print ("I am working!");
			Die();
		}
//		if (coll.gameObject.tag == "coin") {
//			Generate.score += 20;
//			print ("I am scoring!!!");
//			Destroy (coll.gameObject);
//		}

	}
	
	void Die() {
//		animator.SetInteger ("Death", 1);
//		yield return new WaitForSeconds (2f);
		Application.LoadLevel(Application.loadedLevel);
	}


}




