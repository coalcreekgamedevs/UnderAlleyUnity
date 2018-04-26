using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickupCollisions : MonoBehaviour
{
    KeyInventory keyInventory;
    private SpriteRenderer spriteRenderer;
    private bool isPickedUp = false;

    // TODO add sound

    // Use this for initialization
    void Start()
    {
        keyInventory = GameObject.FindWithTag("GameController").GetComponent<KeyInventory>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !isPickedUp)
        {
            isPickedUp = true;
            // TODO trigger effect
            keyInventory.AddKey();
            spriteRenderer.enabled = false;
            Destroy(gameObject, 0.2f);
        }
    }
}