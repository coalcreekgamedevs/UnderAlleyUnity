using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoorController : MonoBehaviour {
    // TODO have to add code to match if need specific keys

    private SpriteRenderer spriteRenderer;
    private AudioSource audioSource;
    private KeyInventory keyInventory;

    // TODO add sound

    // Use this for initialization
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        keyInventory = GameObject.FindGameObjectWithTag("GameController").GetComponent<KeyInventory>();
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if(keyInventory)
            {
                if(keyInventory.GetNumberOfKeys() > 0)
                {
                    audioSource.Play();
                    keyInventory.UseKey();
                    spriteRenderer.enabled = false;
                    Destroy(gameObject, 0.2f);
                }
            }
        }
    }
}
