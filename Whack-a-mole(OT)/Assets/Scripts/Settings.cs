using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Settings : MonoBehaviour
{ 
    public void ResumeGame()
    {
        Time.timeScale = 1f;
    }

    public void Restart()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
        Debug.Log("sceneswitch");
    }

    public void Level_page()
    {

        SceneManager.LoadScene("LevelsPage");
        Debug.Log("sceneswitch");
    }
}