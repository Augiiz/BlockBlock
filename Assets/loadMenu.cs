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
        if (File.Exists(Application.persistentDataPath + "/gay.xd"))
        {
            using (StreamReader sr = new StreamReader(Application.persistentDataPath + "/gay.xd"))
            {
                line = sr.ReadLine();
            }
            SceneManager.LoadScene(Convert.ToInt32(line) + 1);
        }
    }



    public void deleteLoadFile()
    {
        if (File.Exists(Application.persistentDataPath + "/gay.xd")) 
        {
            File.Delete(Application.persistentDataPath + "/gay.xd");
        }       
    }


}