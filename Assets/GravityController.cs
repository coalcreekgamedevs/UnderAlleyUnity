using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GravityPullsLeft()
    {
        Physics2D.gravity = new Vector2(-9.81f, 0);
    }

    public void GravityPullsRight()
    {
        Physics2D.gravity = new Vector2(9.81f, 0);
    }

    public void FlipGravity()
    {
        Physics2D.gravity = -Physics2D.gravity;
    }

}
