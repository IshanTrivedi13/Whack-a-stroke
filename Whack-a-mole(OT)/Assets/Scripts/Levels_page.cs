using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels_page : MonoBehaviour

{

    public GameObjeck PausePanel;

    {

        SceneManager.LoadScene("LevelsPage");
        Debug.Log("sceneswitch");
    }

    public void Continue()
    {

    PausePanel.SetActive(False);
    Time.timeScale = T;

    }


}
