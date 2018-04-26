using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Launches the Attack's Timing Meter
public class PlayerAttackHandler : MonoBehaviour {

    public PlayerAttackClass lightToss;
    public PlayerAttackClass curveBall;
    public PlayerAttackClass powerShot;
    private PlayerAttackClass currentAttack;

    private BattleControllerScript battleController;
    private BattleStates battleStates;
    private BattleTargeting battleTargeting;
    private BattleText battleText;

    private GameObject[] targets;

	// Use this for initialization
	void Start () {
        battleController = GetComponent<BattleControllerScript>();
        battleStates = GetComponent<BattleStates>();
        battleTargeting = GetComponent<BattleTargeting>();
        battleText = GetComponent<BattleText>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LightToss()
    {
        currentAttack = lightToss;

        // if there's only on bad guy or attack hits all, we don't need targeting
        if(battleController.GetNumberOfEnemies() == 1 || !lightToss.singleEnemyHit)
        {
            targets = battleController.GetCurrentBadGuys();
            battleStates.SetState(BattleStates.States.ATTACK);
            StartTimingMeter(lightToss);
        }
        else
        {
            // target
            battleStates.SetState(BattleStates.States.TARGET);

            battleTargeting.EnableTargeting();
            
        }

       


        // perform
        // TODO call from battletargeting??
        // PerformPlayerAttack(lightToss);

        // apply damage

        // finish turn

        // TODO get another turn if one hit
    }

    public void CurveBall()
    {
        StartTimingMeter(curveBall);
    }

    public void PowerShot()
    {
        StartTimingMeter(powerShot);
    }

    private void StartTimingMeter(PlayerAttackClass playerAttack)
    {
        Instantiate(playerAttack.timingMeter, transform.position, transform.rotation);
        Debug.Log(playerAttack.name);
    }

    public void HitEnemys()
    {
        /*
        int numberOfTargets = targets.Length;
        Debug.Log("NumberOfTargets to hit: " + numberOfTargets);
        for (int i = 0; i < 0; i++)
        {
            Debug.Log("Testing");
            GameObject badGuy = targets[i];

            BasicBadGuyHealth basicBadGuyHealth = badGuy.GetComponent<BasicBadGuyHealth>();
            basicBadGuyHealth.RemoveHitPoints(currentAttack.damage);
        }
        */
        battleController.DamageBadGuys(currentAttack.damage);
    }
}
