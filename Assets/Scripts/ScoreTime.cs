using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{
    double score = 0;
    public Text scoreText;
    void Update()
    {
        
        score += Convert.ToDouble(Time.deltaTime) + 0.05;
        if (score % 1 >= 0.5)
        {
            scoreText.text = "";
            scoreText.text = Math.Round(score).ToString();
        }
    }
}
