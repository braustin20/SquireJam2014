using UnityEngine;
using System.Collections;

public class TerrainDestroyer : MonoBehaviour {

	void OnTriggerExit(Collider col){

		Destroy(col.gameObject);
		print("exit trigger");

	}

}
