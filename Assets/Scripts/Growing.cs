using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Growing : MonoBehaviour {
	
//	public GameObject[] playerStates;
//	public Collider2D[] playerStates;
	public Rigidbody2D[] playerStates;

	public int charSize = 1;
	public float sfxVolume;
	public AudioClip grow;
	public AudioClip shrink;


	// Use this for initialization
	void Start () {
		charSize = 1;
		SizeChange ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			if (charSize < 3) { 
				print ("I'm size" + charSize + "and pressed up!");
				charSize += 1;
				AudioSource.PlayClipAtPoint(grow, this.transform.position, sfxVolume);
			}
			SizeChange();
//			SendMessage(charSize);
		}
		if (Input.GetKeyDown(KeyCode.DownArrow)) {
			if (charSize > 1) { 
				print ("I'm size" + charSize + "and pressed down!");
				charSize -= 1;
				AudioSource.PlayClipAtPoint(shrink, this.transform.position, sfxVolume);
			}			
			SizeChange();

		}

	}

	void SizeChange () {

		if (charSize == 1) {

//			playerStates[0].SetActive(true);
//			playerStates[1].SetActive(false);
//			playerStates[2].SetActive(false);

//			playerStates[0].enabled = true;
//			playerStates[1].enabled = false;
//			playerStates[2].enabled = false;

			playerStates[0].isKinematic = false;
			playerStates[1].isKinematic = true;
			playerStates[2].isKinematic = true;

		}

		if (charSize == 2) {

//			playerStates[0].SetActive(false);
//			playerStates[1].SetActive(true);
//			playerStates[2].SetActive(false);

//			playerStates[0].enabled = false;
//			playerStates[1].enabled = true;
//			playerStates[2].enabled = false;

			playerStates[0].isKinematic = true;
			playerStates[1].isKinematic = false;
			playerStates[2].isKinematic = true;

		}

		if (charSize == 3) {

//			playerStates[0].SetActive(false);
//			playerStates[1].SetActive(false);
//			playerStates[2].SetActive(true);

//			playerStates[0].enabled = false;
//			playerStates[1].enabled = false;
//			playerStates[2].enabled = true;

			playerStates[0].isKinematic = true;
			playerStates[1].isKinematic = false;
			playerStates[2].isKinematic = false;
//
		}
	}

}
