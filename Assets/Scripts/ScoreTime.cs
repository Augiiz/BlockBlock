using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{
    double score = 0;
    public Text scoreText;
    string timeDiff = "0";
    public static bool GameIsPaused = false;
    void Update()
    {
        if (!GameIsPaused)
        {
            score += Convert.ToDouble(Time.deltaTime) + 0.05;
        }
        else
        {
            score += Convert.ToDouble(Time.deltaTime);
        }   

        if (score % 1 >= 0.5 && !GameIsPaused)
        {
            scoreText.text = Math.Round(score - Convert.ToDouble(timeDiff)).ToString();
        }


        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                timeDiff = Convert.ToString(Convert.ToDouble(scoreText.text) - Convert.ToDouble(timeDiff));
                GameIsPaused = false;
            }
            else
            {
                timeDiff = Convert.ToString(Convert.ToDouble(timeDiff) + Convert.ToDouble(scoreText.text));
                GameIsPaused = true;
            }
        }

    }
}
