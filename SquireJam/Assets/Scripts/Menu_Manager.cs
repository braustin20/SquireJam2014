using UnityEngine;
using System.Collections;

public class Menu_Manager : MonoBehaviour {

	public GameObject mainCamera;
	public float menuSwitchSpeed = 1f;

	public Vector3 mainMenuRotation;
	public Vector3 titleMenuRotation;
	public Vector3 optionsMenuRotation;
	public Vector3 tutorialsMenuRotation;
	public Vector3 exitMenuRotation;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMenuItemSelected(string menuItemName){

		if(menuItemName == "Start Game"){
			iTween.RotateTo(mainCamera, titleMenuRotation, menuSwitchSpeed);
			print("Start");
			Application.LoadLevel(1);
		}else if(menuItemName == "Play Game"){
			//iTween.RotateTo(mainCamera, optionsMenuRotation, 0.5f);
			print("Play");
		}else if(menuItemName == "Options"){
			iTween.RotateTo(mainCamera, optionsMenuRotation, menuSwitchSpeed);
			print("Options");
		}else if(menuItemName == "Tutorials"){
			iTween.RotateTo(mainCamera, tutorialsMenuRotation, menuSwitchSpeed);
			print("Tutorials");
		}else if(menuItemName == "Exit"){
			iTween.RotateTo(mainCamera, exitMenuRotation, menuSwitchSpeed);
			print("Exit");
		}else if(menuItemName == "Return"){
			iTween.RotateTo(mainCamera, titleMenuRotation, menuSwitchSpeed);
		}

	}
}
