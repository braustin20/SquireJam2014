using UnityEngine;
using System.Collections;

public class RollerControls : MonoBehaviour {

	private GameObject boulder;

	public float strafeSpeed = 1.0f;
	public float constantSpeed = 1.0f;
	public float acceleration = 1.0f;

	public float groundedDelay = 1.0f;
	private float timer;

	public bool grounded = false;
	private bool groundedTimerActive = false;

	// Use this for initialization
	void Start () {
		boulder = GameObject.Find("Boulder");
		boulder.constantForce.force = new Vector3(0, 0, 1.0f) * constantSpeed;
	}
	
	// Update is called once per frame
	void Update () {
		if(groundedTimerActive){

		}

		if(Input.GetKey(KeyCode.A)){
			boulder.rigidbody.AddForce(new Vector3(-1.0f, 0, 0) * strafeSpeed); 
		}
		if(Input.GetKey(KeyCode.D)){
			boulder.rigidbody.AddForce(new Vector3(1.0f, 0, 0) * strafeSpeed); 
		}
		if(Input.GetKey(KeyCode.W)){
			boulder.rigidbody.AddForce(new Vector3(0, 0, 1.0f) * acceleration); 
		}
		if(Input.GetKey(KeyCode.S)){
			boulder.rigidbody.AddForce(new Vector3(0, 0, -1.0f) * acceleration); 
		}
	}
	void OnCollisionExit(Collision other){
		if(other.collider.gameObject.tag == "Terrain"){
			groundedTriggerActive = false;
		}
	}
	void OnCollisionEnter(Collision other){
		if(other.collider.gameObject.tag == "Terrain"){
			groundedTriggerActive = true;
		}
	}
}
