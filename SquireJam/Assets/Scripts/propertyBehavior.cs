using UnityEngine;
using System.Collections;

public class propertyBehavior : MonoBehaviour {

	public bool onFire;
	public bool onWater;
	public bool onIce;
	public bool onSnow;
	public bool onEarth;
	public float currentScale;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (onFire == true) {
			growBoulder(0.1f);
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

	//This function will run code that increases the size of the boulder.
	//This function requires a float to be inputed
	void growBoulder(float sizeIncrease){
		currentScale = currentScale + sizeIncrease;

		currentScale = Mathf.Lerp(1, currentScale, Time.time);

		gameObject.transform.localScale = new Vector3(currentScale, currentScale, currentScale);
	}

	//This function will run code that decreases the size of the boulder
	//This function requires an float to be inputed
	void decreaseBoulder(float sizeDecrease){
		currentScale = currentScale - sizeDecrease;
		
		currentScale = Mathf.Lerp(1, currentScale, Time.time);
		
		gameObject.transform.localScale = new Vector3(currentScale, currentScale, currentScale);
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
