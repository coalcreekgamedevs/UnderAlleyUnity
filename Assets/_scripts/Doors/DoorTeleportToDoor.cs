using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTeleportToDoor : MonoBehaviour {

    public Transform otherDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public Vector2 GetOtherDoorPosition()
    {
        return otherDoor.position;
       
    }
}
