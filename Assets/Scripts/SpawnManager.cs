using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	[SerializeField]
	private GameObject[] animalPrefabs;

	private float spawnRangeX = 20;
	private float spawnPosZ = 20;

	void Update()
    {
		if (Input.GetKeyDown(KeyCode.S)) 
		{
			// Randomly generate animal index and spawn position
			int animalIndex = Random.Range(0, animalPrefabs.Length);
			Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

			Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
		}
    }
}
