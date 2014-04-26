using UnityEngine;
using System.Collections;

public class propertyBehavior : MonoBehaviour {

	public bool onFire;
	public bool onWater;
	public bool onIce;
	public bool onSnow;
	public bool onEarth;
	public float newScale;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (onFire == true) {
			growBoulder();
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
		newScale = Mathf.Lerp(1, 5, Time.time);

		gameObject.transform.localScale = new Vector3(newScale, 1, newScale);
	}

	//This function will run code that decreases the size of the boulder
	void decreaseBoulder(){

	}

	//Function where we will change the boolean variables for the most recent property encountered
	void OnCollisionEnter(Collision otherObject){
		if (otherObject.gameObject.tag == "fire") {

				}
		if (otherObject.gameObject.tag == "water") {
				
				}
		if (otherObject.gameObject.tag == "ice") {

				}
		if (otherObject.gameObject.tag == "earth") {
				
				}
		if (otherObject.gameObject.tag == "snow") {
				
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
