using UnityEngine;
using System.Collections;

public class StaticEnemy: MonoBehaviour {
	private bool destroyed = false;
	private float timer = 0.0f;

	public float deathTime = 3.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if(destroyed){
			if(timer >= deathTime){
				GameObject.Destroy(this);
			}
		}
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.name == "Boulder"){
			rigidbody.AddExplosionForce(3.0f, other.transform.position, 10.0f);
			destroyed = true;
		}
	}
}
