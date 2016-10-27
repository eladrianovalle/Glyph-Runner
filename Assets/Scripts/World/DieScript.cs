using UnityEngine;
using System.Collections;

public class DieScript : MonoBehaviour {

	public bool isDead;
	public AudioClip die;
	public AudioSource audioSrc;
//	public float delay;


	void Start () {
		isDead = false;
//		delay = 5f;
		audioSrc = this.GetComponent<AudioSource>();
	}

	void Update () {

		if (isDead) {
			audioSrc.PlayOneShot(die);
			if (!audioSrc.isPlaying) {
				Die();
//				StartCoroutine(Die());
			}
		}
	}

	void OnCollisionEnter2D(Collision2D coll) {

		if (coll.gameObject.tag == "Player") {
			
			isDead = true;
			
		}
		
	}

	void OnTriggerEnter2D(Collider2D coll) {

		if (coll.gameObject.tag == "Player") {

			if (coll.gameObject.transform.position.y < -6) {

				isDead = true;

			}
		}
	}

//	IEnumerator Die() {
//		yield return new WaitForSeconds(delay);
//		Application.LoadLevel(Application.loadedLevel + 1);
//	}
	
//	void Die(float delay) {
//		yield WaitForSeconds(delay);
//		Application.LoadLevel(Application.loadedLevel + 1);
//	}

	void Die() {
		UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
	}
}
