using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;
using TMPro;
using UnityEngine.UI;

public class mainMenu : MonoBehaviour
{
    string level = "0";
    
    public void PlayGame()
    {
        SceneManager.LoadScene("level01");
    }

    public void endlessGame()
    {
        SceneManager.LoadScene("Endless");
    }
    
    public void loadGame()
    {
        if (File.Exists(Application.persistentDataPath + "/gay.xd"))
        {
            using (StreamReader sr = new StreamReader(Application.persistentDataPath + "/gay.xd"))
            {
                level = sr.ReadLine();
            }
            SceneManager.LoadScene(Convert.ToInt32(level) + 1);
        }
        else level = "0";
    }

    public void checkGameProgressNX()
    {
        if (File.Exists(Application.persistentDataPath + "/gay.xd"))
        {
            using (StreamReader sr = new StreamReader(Application.persistentDataPath + "/gay.xd"))
            {
                level = sr.ReadLine();
            }
        }

    }


    public void loadLevel1()
    {
        SceneManager.LoadScene("level01");
    }


    public void loadLevel2()
    {
        TextMeshProUGUI txt;
        if (Convert.ToInt32(level) < 1)
        {
            
        }
        else SceneManager.LoadScene("level02");
    }
    public void loadLevel3()
    {
        if (Convert.ToInt32(level) < 2) { }
        else SceneManager.LoadScene("level03");
    }
    public void loadLevel4()
    {
        if (Convert.ToInt32(level) < 3) { }
        else SceneManager.LoadScene("level04");
    }
    public void loadLevel5()
    {
        if (Convert.ToInt32(level) < 4) { }
        else SceneManager.LoadScene("level05");
    }
    public void loadLevel6()
    { 
        if (Convert.ToInt32(level) < 5)  { }
        else SceneManager.LoadScene("level06");
    }
    public void loadLevel7()
    {
        if (Convert.ToInt32(level) < 6) { }
        else SceneManager.LoadScene("level07");
    }
    public void loadLevel8()
    {
        if (Convert.ToInt32(level) < 7) { }
        else SceneManager.LoadScene("level08");
    }
    public void loadLevel9()
    {
        if (Convert.ToInt32(level) < 8) { }
        else SceneManager.LoadScene("level09");
    }
    public void loadLevel10()
    {
        if (Convert.ToInt32(level) < 9) { }
        else SceneManager.LoadScene("level10");
    }


    public void deleteLoadFile()
    {
        if (File.Exists(Application.persistentDataPath + "/gay.xd"))
        {
            File.Delete(Application.persistentDataPath + "/gay.xd");
        }
        level = "0";
    }
    public void QuitGame()

    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}