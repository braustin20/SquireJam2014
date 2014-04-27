﻿using UnityEngine;
using System.Collections;

public class propertyBehavior : MonoBehaviour {

	public bool onFire;
	public bool onWater;
	public bool onIce;
	public bool onSnow;
	public bool onEarth;
	public float currentScale;
	float previouseScale;

	//This bool 
	bool growing;
	bool shrinking;
	float increaseAmount;
	float shrinkAmount;

	private float timer;
	// Use this for initialization
	void Start () {
		timer = 0;
		currentScale = 0.1f;
	}
	
	// Update is called once per frame
	void Update () {

		if (growing == true) {
			timer += Time.deltaTime;
			if(timer < 0.05f){
				growBoulder(increaseAmount);
			}else{
				growing = false;
				timer = 0;
			}
				}
		if (shrinking == true) {
			timer += Time.deltaTime;
			if(timer < 0.05f){
				decreaseBoulder(shrinkAmount);
			}else{
				shrinking = false;
				timer = 0;
			}
		}
		
		
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

	//This function will run code that increases the size of the boulder.
	//This function requires a float to be inputed
	void growBoulder(float sizeIncrease){
		previouseScale = currentScale;
		currentScale = currentScale + sizeIncrease;

		currentScale = Mathf.Lerp(previouseScale, currentScale, Time.time);

		gameObject.transform.localScale = new Vector3(currentScale, currentScale, currentScale);


	}

	//This function will run code that decreases the size of the boulder
	//This function requires an float to be inputed
	void decreaseBoulder(float sizeDecrease){
		currentScale = currentScale - sizeDecrease;
		
		currentScale = Mathf.Lerp(1, currentScale, Time.time);
		
		gameObject.transform.localScale = new Vector3(currentScale, currentScale, currentScale);

		if (gameObject.transform.localScale.x < 0.04f) {
			Debug.Log ("Poop");
			shrinking = false;
			Time.timeScale = 0;
		}
	}

	//Function where we will change the boolean variables for the most recent property encountered
	void OnCollisionEnter(Collision otherObject){

		//Game Objects and values they give
		if (otherObject.gameObject.name == "shrinkCube") {
			shrinking = true;
			shrinkAmount = 0.01f;
				}


		if (otherObject.gameObject.name == "Palm" ) {
			if(gameObject.transform.localScale.x >= 0.2f){
			growing = true;
			increaseAmount = 0.03f;
			}else{
				shrinking = true;
				shrinkAmount = 0.01f;
			}
				}

		
		if (otherObject.gameObject.name == "powerCube") {
			Debug.Log("Entered Collision");
			growing = true;
			increaseAmount = 0.01f;
			//growBoulder(0.01f);
				}

		if (otherObject.gameObject.name == "Bush") {
			Debug.Log ("Hit bush");
			growing = true;
			increaseAmount = 0.015f;
		}

		if (otherObject.gameObject.name == "Cube") {
			if(gameObject.transform.localScale.x >= 0.2f){
				growing = true;
				increaseAmount = 0.05f;
			}else{
				shrinking = true;
				shrinkAmount = 0.01f;
			}
				}

		if (otherObject.gameObject.name == "JapaneseMaple") {
			if(gameObject.transform.localScale.x >= 0.4f){
				growing = true;
				increaseAmount = 0.06f;
			}else{
				shrinking = true;
				shrinkAmount = 0.03f;
			}
		}

		if (otherObject.gameObject.name == "watchTower") {
			if(gameObject.transform.localScale.x >= 0.8f){
				growing = true;
				increaseAmount = 0.2f;
			}else{
				shrinking = true;
				shrinkAmount = 0.15f;
			}
				}



	}

	//Function where we will change the boolean variables for the most recent property encountered
	void OnTriggerEnter(Collider otherObject){

		//Hostile game objects
		if (otherObject.gameObject.name == "spikes") {
			
		}
		//Power up game objects
		if (otherObject.gameObject.name == " ") {
			
		}
	}
}
