using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {

	private float startTime;
	private float objectScore = 0;

	// Use this for initialization
	void Start () {

		startTime = Time.time;
	
	}
	
	// Update is called once per frame
	void Update () {

		print(Time.time - startTime);
	
	}

	void OnGUI(){

		GUI.Box(new Rect(10f, 10f, 100f, 30f), (int)(((Time.time - startTime)*30)+objectScore)+"");

	}

	void OnCollisionEnter(Collision col){

		if(col.gameObject.name == "JapaneseMaple"){
			objectScore += 200;
		}else if(col.gameObject.name == "Bush"){
			objectScore += 50;
		}else if(col.gameObject.name == "Palm"){
			objectScore += 100;
		}else if(col.gameObject.name == "house"){
			objectScore += 300;
		}else if(col.gameObject.name == "watchTower"){
			objectScore += 400;
		}else if(col.gameObject.name == "castleOrGG"){
			objectScore += 500;
		}

	}
}
