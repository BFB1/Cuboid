using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Score
{
	
	// Keeps track of the score across scenes.

	private static int totalScore;
	private static int timePenalty = 0;

	public static int TotalScore
	{
		get { return totalScore; }
		set
		{
			totalScore += value;
			timePenalty = 0;
		}
	}
	
	public static void AddPenalty()
	{
		timePenalty++;
	}

	public static void ResetPenalty()
	{
		timePenalty = 0;
	}

	public static void ResetTotalScore()
	{
		totalScore = 0;
	}

	public static double CalculateScore()
	{
		return Math.Max(0, Math.Floor(Time.timeSinceLevelLoad + timePenalty - 1));
	}
}
