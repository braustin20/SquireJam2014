using UnityEngine;
using System.Collections;

public class TerrainGenerator : MonoBehaviour {


	public Terrain StartTerrain;
	public Terrain[] TerrainPieces;

	private Terrain start;
	private Vector3 terrainSize;
	private Vector3 terrainLocation;

	void Start(){

		terrainSize = StartTerrain.terrainData.size;
		terrainLocation = new Vector3(0, 0, 0);
		start = Instantiate(StartTerrain, terrainLocation, Quaternion.identity) as Terrain;

		Instantiate(TerrainPieces[0], new Vector3(0, 0, terrainSize.z), Quaternion.identity);


	}
	
	void Update () {

		print(start.terrainData.size);

	}
}
