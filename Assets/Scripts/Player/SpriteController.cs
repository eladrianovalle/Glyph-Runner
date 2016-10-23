using UnityEngine;
using System.Collections;

public class SpriteController : MonoBehaviour {

	public SpriteRenderer _sRenderer;
	private BoxCollider2D _boxCollider;
	private Rigidbody2D _myBody;

	void Start () {
//		_sRenderer = this.GetComponentInChildren<SpriteRenderer> ();
		_boxCollider = this.GetComponent<BoxCollider2D> ();
//		_myBody = this.GetComponent<Rigidbody2D> ();
	
	}
	
//	void Update () {
////		if (!_boxCollider.enabled)
////			_sRenderer.enabled = false;
////		else if (_boxCollider.enabled)
////			_sRenderer.enabled = true;
//
//		if (_myBody.isKinematic) {
////			_boxCollider.enabled = false;
////			_sRenderer.enabled = false;
//
//		}
//		else if (!_myBody.isKinematic) {
////			_boxCollider.enabled = true;
////			_sRenderer.enabled = true;
//
//		}
//
//	}
}
