using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleControllerScript : MonoBehaviour
{
    public string[] badGuyPrefabNames;
    public GameObject test;

    public Transform[] enemyPositions;
    private int numberOfBadGuys = 0;
    private GameObject[] currentBadGuys;

    // Use this for initialization
    void Start()
    {
        LoadBadGuyPrefabNames();
        CreateEnemiesFromNames(badGuyPrefabNames);
        PositionBadGuys();
    }

    private void LoadBadGuyPrefabNames()
    {
        // load number
        numberOfBadGuys = PlayerPrefs.GetInt("NumberOfEnemies");
        // init arrays
        currentBadGuys = new GameObject[numberOfBadGuys];
        badGuyPrefabNames = new string[numberOfBadGuys];

        // load enemy names
        for (int i = 0; i < numberOfBadGuys; i++)
        {
            badGuyPrefabNames[i] = PlayerPrefs.GetString("EnemyPrefabName" + i);
            Debug.Log("i: " + badGuyPrefabNames[i]);
        }
    }

    private void CreateEnemiesFromNames(string[] names)
    {
        int numberOfNames = names.Length;

        for (int i = 0; i < numberOfNames; i++)
        {
            currentBadGuys[i] = Instantiate(Resources.Load(names[i], typeof(GameObject))) as GameObject;
        }
    }

    private void PositionBadGuys()
    {
        if (numberOfBadGuys == 1)
        {
            currentBadGuys[0].transform.position = enemyPositions[2].position;
            // TODO randomize?
        }
        else
        {
            int numberOfPositions = enemyPositions.Length;
            for (int i = 0; i < numberOfPositions; i++)
            {
                Debug.Log(i + ": " + enemyPositions[i].position);
                currentBadGuys[i].transform.position = enemyPositions[i].position;
            }
        }
    }

    public GameObject[] GetCurrentBadGuys()
    {
        return currentBadGuys;
    }

    public Transform[] GetBadGuyPositions()
    {
        return enemyPositions;
    }

    public int GetNumberOfEnemies()
    {
        return numberOfBadGuys;
    }

    public void DamageBadGuys(int amount)
    {
        /*
        int numberOfPositions = enemyPositions.Length;
        for (int i = 0; i < numberOfPositions; i++)
        {
            Instantiate(test, enemyPositions[i].position, transform.rotation);
        }
        */


        // TODO FIXME Workaround
        RaycastHit2D[] hits = Physics2D.CircleCastAll(enemyPositions[1].position, 1f, Vector2.up, 10f); // right
        int numberofHits = hits.Length - 1;
        Debug.Log("Hits: " + hits.Length);
        for (int i = 0; i < numberofHits; i++)
        {
            // FIXME
            currentBadGuys[i].GetComponent<BasicBadGuyHealth>().RemoveHitPoints(amount);
        }




        Debug.Log("Finished");

        /*
        int targetsToDamage = currentBadGuys.Length;

        Debug.Log("DamageCalled, currentBadGuys # " + currentBadGuys);

        for (int i = 0; i < 0; i++)
        {
            currentBadGuys[i].GetComponent<BasicBadGuyHealth>().RemoveHitPoints(amount);
        }
        */
    }

    /*
    void OnDrawGizmosSelected()
        {
        Debug.Log("Draw");
            GameObject[] objs = FindObjectsOfType(typeof(GameObject)) as GameObject[];
            foreach (GameObject g in objs)
            {
                UnityEditor.Handles.color = Color.green;
                UnityEditor.Handles.DrawWireDisc(g.transform.position, g.transform.up, 2f);
            }
        } 
        */
}
