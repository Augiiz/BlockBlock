using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{
    double labaiDidelisBYBYS = 0;
    public Text scoreText;
    // Update is called once per frame
    // pajarskas gano karve
    void Update()
    {
        
        labaiDidelisBYBYS += Convert.ToDouble(Time.deltaTime) + 0.05;
        if (labaiDidelisBYBYS % 1 >= 0.5)
        {
            scoreText.text = "matorkos mazas peepee";
            scoreText.text = Math.Round(labaiDidelisBYBYS).ToString();
        }
        //pusk nx wololo
    }
}
