using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public void Lvl1()
    {
        SceneManager.LoadScene("Level_1");
        Debug.Log("sceneswitch");
    }
              
         

    
}
