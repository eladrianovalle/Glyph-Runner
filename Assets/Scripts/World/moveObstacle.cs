using UnityEngine;
using System.Collections;

public class moveObstacle : MonoBehaviour {

	public int roomVelocity;
	public float range;

	// Update is called once per frame
	void Update () {

		this.transform.position -= Vector3.right * (roomVelocity * Time.deltaTime);

		if (this.transform.position.x < -20 ) {
			Destroy(gameObject);
//			print("Destroyed!");
		}

		
	}
}
