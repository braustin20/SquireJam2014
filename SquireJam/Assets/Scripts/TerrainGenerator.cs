using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {


	public Terrain StartTerrain;
	public Terrain[] TerrainPieces;
	
	private Vector3 terrainLocation;
	private Terrain prevTerrain;

	void Start(){

		terrainLocation = new Vector3(0, 0, 0);
		prevTerrain = Instantiate(StartTerrain, terrainLocation, Quaternion.identity) as Terrain;

		//prevTerrain = Instantiate(TerrainPieces[(int)Random.Range(0, TerrainPieces.Length)], new Vector3(0, 0, prevTerrain.GetPosition().z + prevTerrain.terrainData.size.z), Quaternion.identity)as Terrain;

	}

	void OnTriggerEnter(Collider col){

		if(col.gameObject.tag == "Terrain"){
			prevTerrain = Instantiate(TerrainPieces[(int)Random.Range(0, TerrainPieces.Length)], new Vector3(0, 0, prevTerrain.GetPosition().z + prevTerrain.terrainData.size.z), Quaternion.identity)as Terrain;
		}

	}
}
