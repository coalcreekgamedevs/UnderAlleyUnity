using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimator : MonoBehaviour {

    private Animator anim;
    private Vector2 previousPosition;

	// Use this for initialization
	void Start () 
    {
        anim = GetComponent<Animator>();
        previousPosition = transform.position;
	}

	private void Update()
	{
        anim.SetFloat("xSpeed", Input.GetAxis("Horizontal"));
        anim.SetFloat("ySpeed", Input.GetAxis("Vertical"));
	}

	// Update is called once per frame
	void LateUpdate () 
    {
        previousPosition = transform.position;
	}
}
