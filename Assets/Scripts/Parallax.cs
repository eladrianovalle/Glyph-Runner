using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Parallax : MonoBehaviour {

	public int bgVelocity;
	public float bgSize;
	public List<SpriteRenderer> bg;

	// Use this for initialization
	void Start () {

		bgSize = bg[0].GetComponent<Renderer>().bounds.size.x;
		bg[0].transform.position = Vector2.right * -bgSize;
		bg[1].transform.position = Vector2.zero;
		bg[2].transform.position = Vector2.right * bgSize;

	}
	
	// Update is called once per frame
	void Update () {

		bg[0].transform.position -= Vector3.right * (bgVelocity * Time.deltaTime);
		bg[1].transform.position -= Vector3.right * (bgVelocity * Time.deltaTime);
		bg[2].transform.position -= Vector3.right * (bgVelocity * Time.deltaTime);
	
		if (bg [1].transform.position.x <= -bgSize) {
			bg.Insert (3, bg[0]);
			bg.RemoveAt (0);
			bg [2].transform.position = new Vector2 (bg [1].transform.position.x + bgSize, 0);
			bg[2].GetComponent<Renderer>().enabled = true;
		}
	}
}
