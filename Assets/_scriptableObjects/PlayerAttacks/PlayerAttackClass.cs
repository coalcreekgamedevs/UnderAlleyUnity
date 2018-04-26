using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Player Attack", menuName = "Player Attacks", order = 1)]
public class PlayerAttackClass : ScriptableObject 
{
    public string objectName = "Player Attack Scriptable Object";
    public int damage = 5;
    public int percentChanceOfFailure = 25;
    public bool singleEnemyHit = true;
    public GameObject hitEffect;
    public GameObject timingMeter; // should this be more defined, gameobject too broad
    // TODO add particles and sound

}
