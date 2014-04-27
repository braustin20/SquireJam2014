using UnityEngine;
using System.Collections;

public class StaticEnemy: MonoBehaviour {
	private bool destroyed = false;
	private float timer = 0.0f;

	public float objectScale = 0.1f;
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
		if(other.collider.gameObject.tag == "Player"){
			if(this.objectScale <= other.collider.gameObject.transform.localScale.x && !destroyed){
				if(this.rigidbody == null){
					this.gameObject.AddComponent<Rigidbody>();
				}
				rigidbody.mass = 0.01f;
				rigidbody.AddForce(new Vector3(0, 0, 1.0f) * 100.0f);
				//rigidbody.AddExplosionForce(3000.0f, other.gameObject.transform.position, 10.0f);
				destroyed = true;
				if(this.name == "Cube"){
					this.transform.parent.gameObject.AddComponent<Rigidbody>();
					this.transform.parent.rigidbody.mass = 0.01f;
					this.transform.parent.rigidbody.AddForce(new Vector3(0, 0, 1.0f) * 100.0f);
				}
			}
		}
	}
}
