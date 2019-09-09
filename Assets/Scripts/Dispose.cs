using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Dispose : MonoBehaviour
{
	
	// Checks whether or not an item should be disposed of in a coroutine

	private bool isNew = true;

	private bool isCollided;

	public float startWait = 15f;
	public float wait = 30f;

	private void Awake()
	{
		StartCoroutine(StartDisposal());
	}

	private IEnumerator StartDisposal()
	{
		if (isNew)
		{
			isNew = false;
			yield return new WaitForSeconds(startWait);
			
		}

		if (isCollided)
		{
			yield return new WaitForSeconds(wait);
		}
		else
		{
			Destroy(gameObject);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		isCollided = true;
	}

	private void OnCollisionExit(Collision other)
	{
		isCollided = false;
	}
}
