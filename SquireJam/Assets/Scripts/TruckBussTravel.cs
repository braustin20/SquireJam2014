using UnityEngine;
using System.Collections;



public class TruckBussTravel : MonoBehaviour {

	public Transform waypoint1;
	public Transform waypoint2;
	
	private Vector3 dir;
	
	public float speed = 10;


	// Use this for initialization
	void Start () {
		dir = waypoint1.position - transform.position;
	}
	
	// Update is called once per frame
	void Update () {

		transform.Translate(dir * (speed/50) * Time.deltaTime, Space.World);
	
	}

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.name == "WayPoint1"){
			Debug.Log ("working");
			dir = waypoint2.position - transform.position;
		}
		if(other.gameObject.name == "WayPoint2"){
			Debug.Log ("working");
			dir = waypoint1.position - transform.position;
		}
	}
}
