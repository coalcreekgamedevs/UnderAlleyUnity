using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTargetController : MonoBehaviour {

    private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
        spriteRenderer = GetComponentInChildren<SpriteRenderer>();
        Hide();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Hide()
    {
        spriteRenderer.enabled = false;
    }

    public void Show()
    {
        spriteRenderer.enabled = true;
    }

}
