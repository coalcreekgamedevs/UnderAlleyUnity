using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleEnemyCollisions : MonoBehaviour {
    BasicBadGuyHealth badGuyHealth;
    private int attackDamage = 10;

	// Use this for initialization
	void Start () {
        badGuyHealth = GetComponent<BasicBadGuyHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        if(collision.CompareTag("BattleAttack"))
        {
            Debug.Log("Battle Attack");
            badGuyHealth.RemoveHitPoints(attackDamage);
        }
	}

    public void SetAttackDamage(int newDamage)
    {
        attackDamage = newDamage;
    }
}
