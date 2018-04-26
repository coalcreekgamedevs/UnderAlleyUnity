using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy Group", menuName = "Enemy Group", order = 1)]
public class EnemyGroupClass : ScriptableObject
{
    public string objectName = "Enemy Group Scriptable Object";
    public int moneyOnDefeat = 5;
    public int experianceOnDefeat = 5;
    public GameObject[] enemies;

    public GameObject[] GetEnemyPrefabs()
    {
        return enemies;
    }
}