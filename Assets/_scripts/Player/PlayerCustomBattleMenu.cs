using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCustomBattleMenu : MonoBehaviour {

    public GameObject battleMenu;
    private TurnController turnController;

	// Use this for initialization
	void Start () {
        turnController = GameObject.FindWithTag("TurnToken").GetComponent<TurnController>();
        CheckMenuVisible();
	}

    private void CheckMenuVisible()
    {
       // battleMenu.SetActive(turnController.GetPlayersTurn());
    }
	
	// Update is called once per frame
	void Update () {
        CheckMenuVisible();
	}
}
