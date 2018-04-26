using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundManager : MonoBehaviour {
    AudioSource audioSource;
    public AudioClip pickupSound;
    public AudioClip teleportSound;
	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void PlayPickedUpBowlingBall()
    {
        audioSource.clip = pickupSound;
        audioSource.Play();
    }

    public void PlayTeleport()
    {
        audioSource.clip = teleportSound;
        audioSource.Play();
    }
}
