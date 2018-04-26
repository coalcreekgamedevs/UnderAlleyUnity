using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTimer : MonoBehaviour {

    [SerializeField]
    private float amountOfTime = 3;
    private float timer;

    bool countingDown = false;

	// Use this for initialization
	void Start () {
		
	}

	public void ResetTimer()
	{
        timer = amountOfTime + Time.time;
        countingDown = true;
	}

	// Update is called once per frame
	void Update () {

	}

    public bool IsTimeUp()
    {
        if(Time.time > timer && countingDown)
        {
            countingDown = false;
            return true;
        }

        return false;
    }
}
