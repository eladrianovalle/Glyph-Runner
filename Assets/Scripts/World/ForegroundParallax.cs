using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class foregroundParallax : MonoBehaviour {
	public GameObject Objects;
	public Vector2 velocity;
//	public List<GameObject> obstacleList;
//	public int threshold;

	
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D>().velocity = velocity;
		this.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
//		float randomRange = threshold * Random.value;
//		this.transform.localScale = new Vector3 ( randomRange, randomRange, transform.localScale.z ); 
	}
	
	// Update is called once per frame
	void Update () {

		if (this.transform.position.x < -15 ) {
			Destroy(Objects);
			print("Destroyed!");
		}

	}
}