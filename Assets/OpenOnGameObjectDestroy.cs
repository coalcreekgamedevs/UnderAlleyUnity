using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenOnGameObjectDestroy : MonoBehaviour {

    GameObject gateKeeperEnemy;
	// Use this for initialization
	void Start () {
        gateKeeperEnemy = GameObject.FindGameObjectWithTag("GateKeeper");
	}
	
	// Update is called once per frame
	void Update () 
    {
        if(!gateKeeperEnemy)
        {
            Destroy(gameObject);
        }
	}
}
