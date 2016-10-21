using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartGame : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.DownArrow)) {
			NextLevel();
		}
	}

	public void NextLevel ()
	{
		int i = Application.loadedLevel;
		Application.LoadLevel(i + 1);
	}

}
