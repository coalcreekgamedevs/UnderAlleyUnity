using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThresholdController : MonoBehaviour {
    [SerializeField]
    private bool isNeedleIn = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        isNeedleIn = false;
	}

	private void OnTriggerStay2D(Collider2D collision)
	{
        if(collision.CompareTag("TimingNeedle"))
        {
            isNeedleIn = true;
        }
	}

    public bool NeedleIsIn()
    {
        return isNeedleIn;
    }
}
