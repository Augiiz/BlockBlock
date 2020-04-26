using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SaveLevel()
    { 
        string oldLevel = "0";

        if (File.Exists(Application.persistentDataPath + "/saveFile.xd"))
        {
            using (StreamReader sr = new StreamReader(Application.persistentDataPath + "/saveFile.xd"))
            {
                oldLevel = sr.ReadLine();
            }
        }


        int newLevel = SceneManager.GetActiveScene().buildIndex;

        if (newLevel > Convert.ToInt32(oldLevel))
        {
            File.WriteAllText(Application.persistentDataPath + "/saveFile.xd", Convert.ToString(newLevel));
        }

    }
    public void backToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
