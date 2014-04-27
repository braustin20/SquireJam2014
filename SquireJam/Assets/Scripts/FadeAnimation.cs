using UnityEngine;
using System.Collections;

public class FadeAnimation : MonoBehaviour {

	// Use this for initialization
	void Start () {

		iTween.FadeFrom(gameObject, iTween.Hash("alpha", 0.1f, "time", 1, "delay", .5f, "looptype", iTween.LoopType.pingPong));

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
