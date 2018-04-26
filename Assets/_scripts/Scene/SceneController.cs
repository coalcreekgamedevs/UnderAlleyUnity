using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{

    NextScene nextScene;

    // Use this for initialization
    void Start()
    {
        nextScene = GetComponent<NextScene>();
    }

    public void LoadNextScene()
    {
        // int SceneManager.
    }

    public void LoadBattleScene()
    {
        SceneManager.LoadScene("BattleSystem", LoadSceneMode.Single);

        /*
        if (SceneManager.GetActiveScene().name == "scene1")
        {
            SceneManager.LoadScene("scene2", LoadSceneMode.Single);
        }
        */
    }

}