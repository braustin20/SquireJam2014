using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {



	public Terrain StartTerrain;
	public GameObject TerrainObjects;
	public Terrain[] TerrainPieces;
	
	private Vector3 terrainLocation;
	private Terrain prevTerrain;

	void Start(){

	

		terrainLocation = new Vector3(0, 0, 0);
		prevTerrain = Instantiate(StartTerrain, terrainLocation, Quaternion.identity) as Terrain;
		GameObject temp = Instantiate(TerrainObjects, terrainLocation, Quaternion.identity) as GameObject;


	}

	void OnTriggerEnter(Collider col){

		if(col.gameObject.tag == "Terrain"){

			prevTerrain = Instantiate(TerrainPieces[(int)Random.Range(0, TerrainPieces.Length)], new Vector3(0, 0, prevTerrain.GetPosition().z + prevTerrain.terrainData.size.z), Quaternion.identity)as Terrain;
			GameObject temp = Instantiate(TerrainObjects, new Vector3(0, 0, prevTerrain.GetPosition().z), Quaternion.identity)as GameObject;


		}

	}
	
}
