using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

// used for splash screen, any key or click to load next level

public class NextScene : MonoBehaviour {

    [SerializeField]
    private int nextScene;

	private void Start()
	{
		
	}

	public void Update()
	{
        if (Input.anyKey)
        {
            StartNextScene();
        }
	}

	public void StartNextScene()
    {
        SceneManager.LoadScene(nextScene);
    }

	
}
