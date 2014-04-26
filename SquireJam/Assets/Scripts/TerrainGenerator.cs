using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {

	public GameObject StartTerrain;
	public GameObject[] TerrainPieces;

	void Start () {

		Object start = Instantiate(StartTerrain);
	
	}
	
	void Update () {



	}
}
