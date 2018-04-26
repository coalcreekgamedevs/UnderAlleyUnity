using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapController : MonoBehaviour {
    public GameObject enemyToActivate;
    public GameObject prefabToSpawn;
    public Transform spawnPoint;
    private bool isTrapSprung = false;

    public AudioClip trapSound;
    private AudioSource audioSource;

	// Use this for initialization
	void Start () 
    {
        audioSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if(collision.CompareTag("Player") && !isTrapSprung)
        {
            PlayTrapSound();
            isTrapSprung = true;
            if(enemyToActivate)
            {
                enemyToActivate.SetActive(true);
            }
            Instantiate(prefabToSpawn, spawnPoint.position, transform.rotation);
        }
	}

    private void PlayTrapSound()
    {
        audioSource.clip = trapSound;
        audioSource.Play();
    }
}
