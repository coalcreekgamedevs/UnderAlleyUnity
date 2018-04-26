using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyInventory : MonoBehaviour {

    private int numberOfKeys = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int GetNumberOfKeys()
    {
        return numberOfKeys;
    }

    public void UseKey()
    {
        numberOfKeys--;
    }

    public void AddKey()
    {
        numberOfKeys++;
    }
}
