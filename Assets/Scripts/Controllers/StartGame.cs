using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartGame : MonoBehaviour {

	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.DownArrow)) {
			NextLevel();
		}
	}

	public void NextLevel ()
	{
		int i = UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex;
		UnityEngine.SceneManagement.SceneManager.LoadScene(i + 1);
	}

}
