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
    public void SaveFuckingLevelLmao()
    {
        string oldLevel = "0";

        if (File.Exists(Application.persistentDataPath + "/gay.xd"))
        {
            using (StreamReader sr = new StreamReader(Application.persistentDataPath + "/gay.xd"))
            {
                oldLevel = sr.ReadLine();
            }
        }


        int newLevel = SceneManager.GetActiveScene().buildIndex;

        if (newLevel > Convert.ToInt32(oldLevel))
        {
            File.WriteAllText(Application.persistentDataPath + "/gay.xd", Convert.ToString(newLevel));
        }

    }
    public void BACKTHEFUCKOFF()
    {
        SceneManager.LoadScene(0);
    }
}
