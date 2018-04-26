using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureBoxStats : MonoBehaviour {

    [SerializeField]
    private int amountOfMoney = 10;

    private bool isEmpty = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int GetMoney()
    {
        if(!isEmpty)
        {
            isEmpty = true;
            return amountOfMoney;
        }

        return 0;
    }
}
