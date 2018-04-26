using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointAdder : MonoBehaviour {
    public GameObject player;
    MoveToPoint moveToPoint;

	// Use this for initialization
	void Start () {
        moveToPoint = player.GetComponent<MoveToPoint>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void GetMouseInput()
    {
        
    }

	private void OnMouseUp()
	{
        Debug.Log(Input.mousePosition);
        Vector2 target;
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Debug.Log(target);
        moveToPoint.AddPoint(target);
	}
}
