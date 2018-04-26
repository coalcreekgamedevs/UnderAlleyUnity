using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimingMeterController : MonoBehaviour {

    public GameObject meter;
    public GameObject threshold;
    public GameObject needle;

    public float moveSpeed = 3;

    enum MiniTimingGame { KEEP_IN_THE_MIDDLE };
    MiniTimingGame currentMiniTimingGame;

    private Rigidbody2D rb;
    private GravityController gravityController;

    /*
     * If you wanted three different attacks for the player I would call them  "Light Toss",
     * "Power Shot", and "Curveball," or something similar.
     */

	// Use this for initialization
	void Start () 
    {
        rb = GetComponentInChildren<Rigidbody2D>();
        gravityController = GetComponent<GravityController>();
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp(KeyCode.Alpha1))
        {
            KeepInTheMiddle();
        }

        if(currentMiniTimingGame == MiniTimingGame.KEEP_IN_THE_MIDDLE)
        {
            // needle.transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
            Vector2 newVel = rb.velocity;
            newVel.x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
            rb.velocity = newVel;
        }

	}

    // threshold centered and arrow/a&d keys used to keep it there
    void KeepInTheMiddle()
    {
        currentMiniTimingGame = MiniTimingGame.KEEP_IN_THE_MIDDLE;
        gravityController.GravityPullsLeft();
        rb.gravityScale = 1;
        Debug.Log(Physics2D.gravity.y);
    }

}
