using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSimplePlayerFollow : MonoBehaviour {

    public Transform player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {
        Vector3 newPos = transform.position;
        newPos.x = player.position.x;
        newPos.y = player.position.y;
        transform.position = newPos;
	}
}
