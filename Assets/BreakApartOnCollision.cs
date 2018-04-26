using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakApartOnCollision : MonoBehaviour {

    [SerializeField]
    private float screenShakeTime = 0.3f;

    private AudioSource audioSource;
    private bool isBroken = false;

    private CircleCollider2D circleCollider;
    private ScreenShakeEffect screenShakeEffect;

	// Use this for initialization
	void Start () {
        audioSource = GetComponent<AudioSource>();
        circleCollider = GetComponent<CircleCollider2D>();

        screenShakeEffect = Camera.main.GetComponent<ScreenShakeEffect>();
	}
	
	// Update is called once per frame
	void Update () {
        if(isBroken)
        {
            Destroy(circleCollider);
            Destroy(this);
        }
	}



	private void OnCollisionEnter2D(Collision2D collision)
	{
        if(collision.collider.CompareTag("Player") && !isBroken)
        {
            isBroken = true;

            screenShakeEffect.SetShakeTime(screenShakeTime);
            screenShakeEffect.StartShaking();

            Rigidbody2D[] rigidbodies = GetComponentsInChildren<Rigidbody2D>();
            foreach(Rigidbody2D rigidbody in rigidbodies)
            {
                rigidbody.isKinematic = false;
                audioSource.time = 1;
                audioSource.Play();
            }

        }

	}
}
