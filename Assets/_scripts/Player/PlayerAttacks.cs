using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttacks : MonoBehaviour {

    public BattleTargeting battleTargeting;

	// Use this for initialization
	void Start () {
        battleTargeting = GameObject.FindWithTag("BattleController").GetComponent<BattleTargeting>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Attack1(PlayerAttackClass attack)
    {
        if(attack.singleEnemyHit)
        {
            UseSingleAttack(attack);
        }

        if(!attack.singleEnemyHit)
        {
            UseAllAttack(attack);
        }
    }

    private void UseSingleAttack(PlayerAttackClass attack)
    {
        GameObject tempEffect = Instantiate(attack.hitEffect, battleTargeting.GetCurrentTargetPosition(), transform.rotation);
        Destroy(tempEffect, 1.0f);
        // TODO how to damage target???
    }

    private void UseAllAttack(PlayerAttackClass attack)
    {
        Vector2[] targetPositions = battleTargeting.GetAllTargetPositions();
        int numberOfTargets = targetPositions.Length;
        for (int i = 0; i < numberOfTargets; i++)
        {
            GameObject tempEffect = Instantiate(attack.hitEffect, targetPositions[i], transform.rotation);
            Destroy(tempEffect, 1.0f);
        }
           
    }

}
