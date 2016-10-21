using UnityEngine;
using System.Collections;

public class Credits : MonoBehaviour {
	public Color creditsColor;
	public SpriteRenderer sRenderer;


	// Use this for initialization
	void Start () {
		sRenderer = GetComponent<SpriteRenderer>();
	}

	void OnMouseOver() {
		sRenderer.color = new Color (0,0,0);
	}

	void OnMouseExit() {
		sRenderer.color = new Color (255,255,255);
	}

	void OnMouseDown() {
		Application.LoadLevel("Credits");
	}

}
