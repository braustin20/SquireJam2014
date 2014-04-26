using UnityEngine;
using System.Collections;

public class cameraFollow : MonoBehaviour {
	private GameObject boulder;
	private Vector3 tempPosition;

	// Use this for initialization
	void Start () {
		boulder = GameObject.Find("Boulder");
	}
	
	// Update is called once per frame
	void Update () {
		tempPosition = new Vector3(boulder.transform.position.x, boulder.transform.position.y - 1.0f, boulder.transform.position.z - 1.5f);
		this.transform.position = tempPosition;
	}
}
