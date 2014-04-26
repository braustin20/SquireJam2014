using UnityEngine;
using System.Collections;

public class RollerControls : MonoBehaviour {

	private GameObject boulder;

	public float strafeSpeed = 1.0f;

	// Use this for initialization
	void Start () {
		boulder = GameObject.Find("Boulder");
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.A)){
			boulder.rigidbody.AddForce(new Vector3(-1, 0, 0) * strafeSpeed); 
		}
		if(Input.GetKey(KeyCode.D)){
			boulder.rigidbody.AddForce(new Vector3(1, 0, 0) * strafeSpeed); 
		}
	}
}
