using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupCollisions : MonoBehaviour {

    SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if(collision.CompareTag("Player"))
        {
            spriteRenderer.enabled = false;
            Destroy(gameObject, 0.2f);
        }

	}
}
