using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class LevelComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void SaveFuckingLevelLmao()
    {
        File.Delete(Application.persistentDataPath + "/gay.xd");
        using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(Application.persistentDataPath + "/gay.xd", true))
        {
            int levelL0L = SceneManager.GetActiveScene().buildIndex;
            file.WriteLine(levelL0L);
        }
    }
    public void BACKTHEFUCKOFF()
    {
        SceneManager.LoadScene(0);
    }
}
