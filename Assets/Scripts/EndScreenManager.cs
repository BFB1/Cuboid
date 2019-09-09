using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreenManager : MonoBehaviour
{
    
    // Sets up and has functions for buttons in the end screen
    
    public TextMeshProUGUI score;

    private void Awake()
    {
        score.text = "FINAL SCORE: " + Score.TotalScore;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
