﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("level01");
    }

    public void QuitGame()

    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}