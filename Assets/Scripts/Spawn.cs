using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	//objects - gameobjects to be spawned - supply prefabs here
	public GameObject[] objects;
	//Number of seconds between spawns
	public float spawnTime;
	//Where to spawn - currently based on the player's position
	private Vector3 spawnPosition;
	//OR - spawn at specified points
	public GameObject[] points;

	public GameObject player;

	// Use this for initialization
	void Start () {
		//TODO: change this to spawn after an animal dies
		InvokeRepeating ("SpawnBoar", 0, spawnTime);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SpawnBoar () {
		//spawn in area around player (for now)
	
		player = GameObject.FindGameObjectWithTag ("Player");
		Vector3 spawnRadius = player.transform.position;

		spawnPosition.x = Random.Range ((spawnRadius.x - 10), (spawnRadius.x + 10));
		spawnPosition.y = spawnRadius.y;
		spawnPosition.z = Random.Range ((spawnRadius.z - 10), (spawnRadius.z + 10));
	
		Instantiate (objects [UnityEngine.Random.Range (0, objects.Length - 1)]
		             , spawnPosition, Quaternion.Euler (90,0,0));
	}

}
