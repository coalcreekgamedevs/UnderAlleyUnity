using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugToken : MonoBehaviour 
{

    public Color playersColor;
    public Color aiColor;
    private SpriteRenderer sr;
    private TurnController turnController;

	// Use this for initialization
	void Start () 
    {
        sr = GetComponentInChildren<SpriteRenderer>();
        turnController = GetComponentInChildren<TurnController>();
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(turnController.GetPlayersTurn())
        {
            SetColorToPlayersTurn();
        }
        else
        {
            SetColorToAIsTurn();    
        }
	}

    private void SetColorToPlayersTurn()
    {
        sr.color = playersColor;
    }

    private void SetColorToAIsTurn()
    {
        sr.color = aiColor;
    }
}
