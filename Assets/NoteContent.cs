using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteContent : MonoBehaviour {

    string noteText = "This is a test and only a test!";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public string GetContent()
    {
        return noteText;
    }

}
