using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	
	// Spawns an item in a predefined area
	
	public GameObject item;

	public float spawnRate;

	public Vector3 spawnArea;
	
	void Update ()
	{
		float numNewItems = spawnRate / (1.0f / Time.smoothDeltaTime);

		for (int i = 0; i < numNewItems; i++)
		{
			Instantiate(
				item, 
				new Vector3(
				Random.Range(-spawnArea.x, spawnArea.x),
				spawnArea.y,
				Random.Range(-spawnArea.z, spawnArea.z)),
				Quaternion.identity);
		}
	}
}
