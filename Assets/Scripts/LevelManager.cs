using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	
	// Contains functions pertaining to the level and updates the score count

	public static LevelManager Instance;
	public GameObject successUi;
	public TextMeshProUGUI scoreUi;
	public TextMeshProUGUI gameOverScoreUi;
	public bool isComplete = false;

	// Use this for initialization
	private void Awake () {
		if (Instance == null)
		{
			Instance = this;
		}
		else
		{
			Debug.LogError("There should never be two level managers active at the same time");
		}
	}

	private void Update()
	{
		//Output the current score to the screen
		//if the Level complete ui has not been enabled and thus the level has not ended
		if (!isComplete)
		{
			scoreUi.text = Score.CalculateScore().ToString();
		}
	}

	public void LevelComplete()
	{
		isComplete = true;
		gameOverScoreUi.text = "SCORE: " + Score.CalculateScore();
		successUi.SetActive(true);
		Score.TotalScore = (int)Score.CalculateScore();
	}
}
