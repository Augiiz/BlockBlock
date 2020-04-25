using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class loadMenu : MonoBehaviour
{

    public void loadGame()
    {
        string line;

        using (StreamReader sr = new StreamReader(Application.persistentDataPath + "/gay.xd"))
        {
            line = sr.ReadLine();
        }
        SceneManager.LoadScene(Convert.ToInt32(line) + 1);
    }

}