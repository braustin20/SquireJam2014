using UnityEngine;
using System.Collections;

public class RollerControls : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Constantly adds force to player bolder
		constantForce.force = new Vector3 (0, 0, 1);

		if(Input.GetKey(KeyCode.A)){
			
		}
	}
}
