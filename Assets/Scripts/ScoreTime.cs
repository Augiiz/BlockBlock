using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreTime : MonoBehaviour
{
    int timer;

    public Text scoreText;
    // Update is called once per frame
    void Update()
    {
        timer += Convert.ToInt32(Time.deltaTime);
        scoreText.text = timer.ToString();
    }
}
