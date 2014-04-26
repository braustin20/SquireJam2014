using UnityEngine;
using System.Collections;

public class StaticEnemy: MonoBehaviour {
	private bool destroyed = false;
	private float timer = 0.0f;

	public float deathTime = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(destroyed){
			timer += Time.deltaTime;

			if(timer >= deathTime){
				Debug.Log(timer);
				GameObject.Destroy(this.gameObject);
			}
		}
	}
	void OnCollisionEnter(Collision other)
	{
		if(other.collider.gameObject.name == "Boulder"){
			rigidbody.AddExplosionForce(300.0f, other.gameObject.transform.position, 100.0f);
			Debug.Log ("hit object");
			destroyed = true;
		}
	}
}
