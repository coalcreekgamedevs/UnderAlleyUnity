using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// LIGHT TOSS
public class KeepInTheMiddleController : MonoBehaviour {

    public GameObject meter;
    public GameObject threshold;
    public GameObject needle;

    public float moveSpeed = 25;

    private Rigidbody2D rb;
    private GravityController gravityController;
    private SimpleTimer simpleTimer;
    private ThresholdController thresholdController;

    private PlayerAttackHandler playerAttackHandler;
    private BattleText battleText;

    /*
     * If you wanted three different attacks for the player I would call them  "Light Toss",
     * "Power Shot", and "Curveball," or something similar.
     */

    // Use this for initialization
    void Start()
    {
        rb = GetComponentInChildren<Rigidbody2D>();
        gravityController = GetComponent<GravityController>();
        simpleTimer = GetComponent<SimpleTimer>();
        thresholdController = GetComponentInChildren<ThresholdController>();

        playerAttackHandler = GameObject.FindWithTag("BattleController").GetComponent<PlayerAttackHandler>();
        battleText = GameObject.FindWithTag("BattleTextController").GetComponent<BattleText>();

        Setup();
        simpleTimer.ResetTimer();
    }

    // Update is called once per frame
    void Update()
    {
        // needle.transform.Translate(Input.GetAxis("Horizontal"), 0, 0);
        Vector2 newVel = rb.velocity;
        newVel.x = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        rb.velocity = newVel;

        if(simpleTimer.IsTimeUp())
        {
            
            Debug.Log("Time up");
            if(thresholdController.NeedleIsIn())
            {

                Debug.Log("IN");
                battleText.EnableHitText();
                playerAttackHandler.HitEnemys();
            }
            else
            {

                Debug.Log("OUT");
                battleText.EnableGutterText();
            }
            Destroy(gameObject, 0.02f);

        }
    }

    // threshold centered and arrow/a&d keys used to keep it there
    void Setup()
    {
        gravityController.GravityPullsLeft();
        rb.gravityScale = 1;
        Debug.Log(Physics2D.gravity.y);
    }

}
