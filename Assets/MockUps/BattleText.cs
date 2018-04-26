using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// gutter = 1, hit = 2, strike = 3

public class BattleText : MonoBehaviour {

    const int EMPTY = 0;
    const int GUTTER = 1;
    const int HIT = 2;
    const int STRIKE = 3;

    [SerializeField]
    private float displayTime = 100;
    [SerializeField]
    private bool isDisplayed = false;
    private float displayTimer;
    Animator anim;

	// Use this for initialization
	void Start () {
        anim = GetComponent<Animator>();
	}

	private void ResetTimer()
	{
        displayTimer = Time.time + displayTime;
        isDisplayed = true;
	}

	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp(KeyCode.X))
        {
            EnableHitText();
        }

        if(isDisplayed)
        {
            if(IsTimeUp())
            {
                isDisplayed = false;
                anim.SetInteger("TextNumber", EMPTY);
            }
        }
	}

    private bool IsTimeUp()
    {
        if(Time.time > displayTime)
        {
            return true;
        }

        return false;
    }


    public void EnableGutterText()
    {
        anim.SetInteger("TextNumber", GUTTER);
        ResetTimer();
    }

	public void EnableHitText()
	{
        anim.SetInteger("TextNumber", HIT);
        ResetTimer();
	}

    public void EnableStrikeText()
    {
        anim.SetInteger("TextNumber", STRIKE);
        ResetTimer();
    }
}
