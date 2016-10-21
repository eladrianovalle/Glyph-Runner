using UnityEngine;
using System.Collections;

public class PlayerCharacter : MonoBehaviour {

	// player component variables
	public SpriteRenderer _sRenderer;
	public BoxCollider2D _collider;
	public Rigidbody2D _rBody;

	// player state variables
	public enum PlayerState { Cat, Man, God };
	public PlayerState currentState;
	public int charSize;

	// audio variables
	public float sfxVolume;
	public AudioClip grow;
	public AudioClip shrink;

	// player gameobject variables
	public GameObject[] playerObjStates;


	void Start () {

		// get components
		_sRenderer = this.GetComponent<SpriteRenderer> ();
		_collider = this.GetComponent<BoxCollider2D> ();
		_rBody = this.GetComponent<Rigidbody2D> ();


		// set character size and state
		charSize = 1;
		SizeChange ();
	}


	public void SizeChange () {

		if (charSize == 1) {

			currentState = PlayerCharacter.PlayerState.Cat;

			playerObjStates[1].SetActive(false);
			playerObjStates[2].SetActive(false);

			playerObjStates[0].SetActive(true);

		}

		if (charSize == 2) {

			currentState = PlayerCharacter.PlayerState.Man;

			playerObjStates[0].SetActive(false);
			playerObjStates[2].SetActive(false);

			playerObjStates[1].SetActive(true);

		}

		if (charSize == 3) {

			currentState = PlayerCharacter.PlayerState.God;

			playerObjStates[0].SetActive(false);
			playerObjStates[1].SetActive(false);

			playerObjStates[2].SetActive(true);

		}
	}


}
