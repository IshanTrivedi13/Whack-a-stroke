using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels_page : MonoBehaviour

{

    public void Lvl_page()
    {

        SceneManager.LoadScene("LevelsPage");
        Debug.Log("sceneswitch");
    }

}
