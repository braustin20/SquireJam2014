using UnityEngine;
using System.Collections;

public class propertyBehavior : MonoBehaviour {

	public bool onFire;
	public bool onWater;
	public bool onIce;
	public bool onSnow;
	public bool onEarth;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (onFire == true) {

				}
		if (onWater == true) {
				
				}
		if (onIce == true) {
				
				}
		if (onSnow == true) {
				
				}
		if (onEarth == true) {
				
				}
		
	}

	//This function will run code that increases the size of the boulder
	void growBoulder(){

	}

	//This function will run code that decreases the size of the boulder
	void decreaseBoulder(){

	}

	//Function where we will change the boolean variables for the most recent property encountered
	void OnCollisionEnter(Collider otherObject){
		if (otherObject.tag == "fire") {

				}
		if (otherObject.tag == "water") {
				
				}
		if (otherObject.tag == "ice") {

				}
		if (otherObject.tag == "earth") {
				
				}
		if (otherObject.tag == "snow") {
				
				}
	}

	//Function where we will change the boolean variables for the most recent property encountered
	void OnTriggerEnter(Collider otherObject){
		if (otherObject.tag == "fire") {
			
		}
		if (otherObject.tag == "water") {
			
		}
		if (otherObject.tag == "ice") {
			
		}
		if (otherObject.tag == "earth") {
			
		}
		if (otherObject.tag == "snow") {
			
		}
	}
}
