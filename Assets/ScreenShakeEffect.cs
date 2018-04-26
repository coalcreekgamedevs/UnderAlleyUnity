using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShakeEffect : MonoBehaviour 
{

    private Vector3 normalPosition;

    public bool debug = false;

    public float shakeTime = 1;
    private float shakeTimer = 0;

    private float shakePower = 0.25f;

    // Use this for initialization
    void Start()
    {
        normalPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (debug)
        {
            Debug();
        }


        if (!TimeUp())
        {
            Shake();
        }
        else
        {
            transform.position = normalPosition;
        }
    }

    private void Debug()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            ResetTimer();
        }
    }

    // TODO public setters for power and time

    private void Shake()
    {
        transform.position = normalPosition;
        Vector3 newPos = transform.position;
        newPos.x = newPos.x + RandomShakeValue();
        newPos.y = newPos.y + RandomShakeValue();
        transform.position = newPos;
    }

    public void StartShaking()
    {
        ResetTimer();
    }

    private float RandomShakeValue()
    {
        return Random.Range(-shakePower, shakePower);
    }

    private float RandomShakeValue(float power)
    {
        return Random.Range(-power, power);
    }

    bool TimeUp()
    {
        if (Time.time > shakeTimer)
        {
            return true;
        }

        return false;
    }

    void ResetTimer()
    {
        shakeTimer = Time.time + shakeTime;
    }

    public void SetShakeTime(float newShakeTime)
    {
        shakeTime = newShakeTime;
    }
}