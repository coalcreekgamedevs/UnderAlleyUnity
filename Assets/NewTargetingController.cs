using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewTargetingController : MonoBehaviour {
    SceneManager sceneManager;
    [SerializeField]
    private int damage = 10;
    GameObject[] battleEnemies;
    public LayerMask layerMask;

    public GameObject target1;
    public GameObject target2;
    public GameObject target3;

    private bool isSingleTarget = true;

    private int currentTarget = 1;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKeyUp(KeyCode.RightArrow))
        {
            NextTarget();
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            PrevTarget();
        }
	}

    private void NextTarget()
    {
        if(currentTarget >= 3)
        {
            currentTarget = 1;
        }else
        {
            currentTarget++;    
        }
        ShowCurrentTarget();
    }

    private void PrevTarget()
    {
        if(currentTarget <= 1)
        {
            currentTarget = 3;
        }
        else
        {
            currentTarget--;    
        }

        ShowCurrentTarget();
    }

    private void ShowCurrentTarget()
    {
        HideAllTargets();
        if(currentTarget == 1)
        {
            ShowTarget(target1);
        }
        else if(currentTarget == 2)
        {
            ShowTarget(target2);
        }
        else
        {
            ShowTarget(target3);
        }
    }

    private void HideAllTargets()
    {
        HideTarget(target1);
        HideTarget(target2);
        HideTarget(target3);
    }

    private void ShowAllTargets()
    {
        ShowTarget(target1);
        ShowTarget(target2);
        ShowTarget(target3);
    }

    public void TargetSingle()
    {
        ShowCurrentTarget();
        isSingleTarget = true;
    }

    public void TargetAll()
    {
        isSingleTarget = false;
        /*
        battleEnemies = GameObject.FindGameObjectsWithTag("BattleEnemy");
        int numberOfEnemies = battleEnemies.Length;
        Debug.Log("numberOfEnemies: " + numberOfEnemies);
        for (int i = 0; i < numberOfEnemies; i++)
        {
            battleEnemies[i].GetComponent<BasicBadGuyHealth>().RemoveHitPoints(damage);
        }
        */
        ShowAllTargets();
    }

    private void ShowTarget(GameObject target)
    {
        target.GetComponent<NewTargetController>().Show();
    }

    private void HideTarget(GameObject target)
    {
        target.GetComponent<NewTargetController>().Hide();
    }

    public void ApplyDamage()
    {
        // hit everyone
        battleEnemies = GameObject.FindGameObjectsWithTag("BattleEnemy");
        int numberOfEnemies = battleEnemies.Length;
        Debug.Log("numberOfEnemies: " + numberOfEnemies);
        for (int i = 0; i < numberOfEnemies; i++)
        {
            battleEnemies[i].GetComponent<BasicBadGuyHealth>().RemoveHitPoints(damage);
        }

        battleEnemies = GameObject.FindGameObjectsWithTag("BattleEnemy");
        int enemiesLeft = battleEnemies.Length;
        if(enemiesLeft >= 0)
        {
            // Go back to OverWorld

        }
    }


}
