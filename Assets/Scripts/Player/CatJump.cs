using UnityEngine;
using System.Collections;

public class CatJump : MonoBehaviour {
	
	public Animator[] anims;

	public AudioClip[] catJumps;
	public float sfxVolume;

	public void Start () {
		anims = GetComponentsInChildren<Animator> ();

	}

	public void Jump(int playerState) {

		foreach (Animator anim in anims) {
			if (anim.gameObject.transform.parent != null) {
				anim.SetTrigger("Jumping");
			} else {
				if (playerState == 1) {
					anim.SetTrigger ("Jump1");
					AudioSource.PlayClipAtPoint(catJumps[0], this.transform.position, sfxVolume);
				}
				if (playerState == 2) {
					anim.SetTrigger ("Jump2");
					AudioSource.PlayClipAtPoint(catJumps[1], this.transform.position, sfxVolume);
				}
				if (playerState == 3) {
					anim.SetTrigger ("Jump3");
					AudioSource.PlayClipAtPoint(catJumps[2], this.transform.position, sfxVolume);
				}
			}
		}
	}
}