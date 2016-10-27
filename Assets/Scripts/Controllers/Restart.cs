using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.DownArrow)) {
			RestartLevel();
		}
	}
	
	public void RestartLevel () {
		if (SceneManager.GetActiveScene().buildIndex == 3) {

			SceneManager.LoadScene (0);

		} else {

			SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex - 1);

		}
	}
}
