using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureBoxCollisions : MonoBehaviour {

    TreasureBoxAnimationController treasureBoxAnimationController;

	// Use this for initialization
	void Start () {
        treasureBoxAnimationController = GetComponent<TreasureBoxAnimationController>();
	}
	
    private void OnTriggerEnter2D(Collider2D collision)
	{
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Open");
            // open chest
            treasureBoxAnimationController.OpenBox();
        }
	}
}
