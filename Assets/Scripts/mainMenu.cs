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
        if (File.Exists(Application.persistentDataPath + "/saveFile.xd"))
        {
            using (StreamReader sr = new StreamReader(Application.persistentDataPath + "/saveFile.xd"))
            {
                level = sr.ReadLine();
            }
            SceneManager.LoadScene(Convert.ToInt32(level) + 1);
        }
        else level = "0";
    }
    

    public void checkGameProgress()
    {
        if (File.Exists(Application.persistentDataPath + "/saveFile.xd"))
        {
            using (StreamReader sr = new StreamReader(Application.persistentDataPath + "/saveFile.xd"))
            {
                level = sr.ReadLine();
            }
        }

        GameObject l2 = GameObject.Find("level2Button");
        GameObject l3 = GameObject.Find("level3Button");
        GameObject l4 = GameObject.Find("level4Button");
        GameObject l5 = GameObject.Find("level5Button");

        if (Convert.ToInt32(level) < 1 && l2.activeSelf) l2.SetActive(false);
        if (Convert.ToInt32(level) < 2 && l3.activeSelf) l3.SetActive(false);
        if (Convert.ToInt32(level) < 3 && l4.activeSelf) l4.SetActive(false);
        if (Convert.ToInt32(level) < 4 && l5.activeSelf) l5.SetActive(false);

    }


    public void loadLevel2()
    {
        if (Convert.ToInt32(level) < 1) { }
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



    public void deleteLoadFile()
    {
        if (File.Exists(Application.persistentDataPath + "/saveFile.xd"))
        {
            File.Delete(Application.persistentDataPath + "/saveFile.xd");
        }
        level = "0";

        checkGameProgress();
    }
    public void QuitGame()

    {
        Debug.Log("QUIT!");
        Application.Quit();
    }
}
