using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndLevelTrigger : MonoBehaviour {

	// Ends the level once the player hits the trigger
	
	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.layer == 9)
		{
			LevelManager.Instance.LevelComplete();
		}
	}
}
