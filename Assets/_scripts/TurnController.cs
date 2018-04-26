using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnController : MonoBehaviour {

    [SerializeField]
    private bool isPlayersTurn;
    private bool isDebugging = true;


	// Use this for initialization
	void Start () 
    {
        isPlayersTurn = RandomBool();
	}

    private bool RandomBool()
    {
        return(Random.Range(0, 2) == 0);
    }
	
	// Update is called once per frame
	void Update () 
    {
        if(isDebugging)
        {
            Debug();
        }
	}

    void Debug()
    {
        // toggle token
        if(Input.GetKeyUp(KeyCode.Space))
        {
            FinishTurn();
        }
    }

    public void StartPlayerTurn()
    {
        
    }

    public void StartAITurn()
    {
        
    }


    public void FinishTurn()
    {
        isPlayersTurn = !isPlayersTurn;
    }

    public bool GetPlayersTurn()
    {
        return isPlayersTurn;
    }
}
