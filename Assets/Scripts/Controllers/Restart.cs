using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.DownArrow)) {
			RestartLevel();
		}
	}
	
	public void RestartLevel () {
		if (Application.loadedLevel == 3) {
			Application.LoadLevel(0);
		} else {
			Application.LoadLevel (Application.loadedLevel - 1);
		}
	}
}
