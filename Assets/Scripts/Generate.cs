using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Generate : MonoBehaviour {
	
	public List<GameObject> roomList;
	public int rangeCeil;
	public float timeBeforeStart;
	public float timeToWait;
	
//	public static int score = 0;
	//	public GUIText scoreText;
	//	int score = 0;
	
	// Use this for initialization
	void Start () {

		rangeCeil = roomList.Count;

		InvokeRepeating("CreateObstacle", timeBeforeStart, timeToWait);
	}
	
	void CreateObstacle() {
		float roomSize = 15.1f;
		int randomRoom = Random.Range (0, rangeCeil);
//		print ("Making obstacle number: " + randomRoom);
		Vector3 pos = transform.TransformPoint((this.transform.position.x + roomSize), this.transform.position.y, this.transform.position.z);
		Instantiate (roomList [randomRoom], pos, Quaternion.identity);		
	}
}
