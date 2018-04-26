using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugKeys : MonoBehaviour {

    [SerializeField]
    private int overWorldIndex;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp(KeyCode.Escape))
        {
            Debug.Log("overworld scene");
            /*
            int currentScene = SceneManager.GetActiveScene().buildIndex;
            int prevScene = currentScene - 1;
            */
            SceneManager.LoadScene(overWorldIndex);
        }

	}
}
