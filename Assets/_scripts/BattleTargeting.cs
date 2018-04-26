using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleTargeting : MonoBehaviour {
    BattleControllerScript battleController;
    private BattleStates battleStates;
    public GameObject targetPrefab;
    [SerializeField]
    private int currentTargetIndex = 0;
    private int numberOfTargets = 0;
    private GameObject[] targets;
    private Transform[] badGuyPositions;


	// Use this for initialization
	void Start () {
        
        battleController = GameObject.FindWithTag("BattleController").GetComponent<BattleControllerScript>();
        // TODO why 0??
        numberOfTargets = PlayerPrefs.GetInt("NumberOfEnemies");
        Debug.Log("battle targeting: " + numberOfTargets);

        battleStates = battleController.GetComponent<BattleStates>();
        badGuyPositions = new Transform[numberOfTargets];
        badGuyPositions = battleController.GetBadGuyPositions();
        CreateTargets();
	}

    public void EnableTargeting()
    {
        Debug.Log("Targeting Enabled");

    }

    void CreateTargets()
    {
        targets = new GameObject[numberOfTargets];
            
        for (int i = 0; i < numberOfTargets; i++)
        {
            targets[i] = Instantiate(targetPrefab, badGuyPositions[i].transform.position, transform.rotation);
            // targets[i].SetActive(false);
        }
    }

    private void SetAllTargetsActive(bool isActive)
    {
        for (int i = 0; i < numberOfTargets; i++)
        {
            targets[i].SetActive(isActive);
        }
    }
	
	// Update is called once per frame
	void Update () {

        // TODO make Battle States for Menu, Targeting, player, ai
        if (battleStates.GetCurrentState() == BattleStates.States.TARGET)
        {

            if (Input.GetKeyUp(KeyCode.T))
            {
                TargetSingle();
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                TargetAll();
            }

            if (Input.GetKeyUp(KeyCode.RightArrow))
            {
                TargetNext();
            }

            if (Input.GetKeyUp(KeyCode.LeftArrow))
            {
                TargetPrevious();
            }

        }
	}


    private void HighlightCurrentTargets()
    {
        Debug.Log("Target size: " + targets.Length);

       // if(!targets[currentTargetIndex].activeSelf)
      //  targets[currentTargetIndex].SetActive(true);
    }

    public void TargetNext()
    {
        SetAllTargetsActive(false);

        if(currentTargetIndex >= numberOfTargets)
        {
            currentTargetIndex = 0;
        }
        else
        {
            currentTargetIndex++;    
        }

        HighlightCurrentTargets();
    }

    public void TargetPrevious()
    {
        SetAllTargetsActive(false);

        if(currentTargetIndex <= 0)
        {
            currentTargetIndex = numberOfTargets;
        }
        else
        {
            currentTargetIndex--;    
        }

        HighlightCurrentTargets();
    }

    public void TargetSingle()
    {
        SetAllTargetsActive(false);
        HighlightCurrentTargets();
    }

    public void TargetMultiple()
    {
        
    }

    public void TargetAll()
    {
        SetAllTargetsActive(true);
    }

    public Vector2[] GetAllTargetPositions()
    {
        if(numberOfTargets < 1)
        {
            Debug.Log("danger will robinson");
        }
        Vector2[] allTargetPositions = new Vector2[numberOfTargets];
        for (int i = 0; i < numberOfTargets; i++)
        {
            allTargetPositions[i] = targets[i].transform.position;
        }

        return allTargetPositions;
    }

    public Vector2 GetCurrentTargetPosition()
    {
        return targets[currentTargetIndex].transform.position;
    }
}
