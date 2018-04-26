using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGroup : MonoBehaviour
{

    public EnemyGroupClass enemyGroupClass;

    // Use this for initialization
    void Start()
    {

    }

    public void SaveEnemyGroupStats()
    {
        GameObject[] enemies = enemyGroupClass.GetEnemyPrefabs();
        int numberOfEnemies = enemies.Length;
        PlayerPrefs.SetInt("NumberOfEnemies", numberOfEnemies);
        string[] names = new string[numberOfEnemies];

        for (int i = 0; i < numberOfEnemies; i++)
        {
            PlayerPrefs.SetString("EnemyPrefabName" + i, enemies[i].name);
        }
    }

    public EnemyGroupClass GetEnemyGroupClass()
    {
        return enemyGroupClass;
    }
}
