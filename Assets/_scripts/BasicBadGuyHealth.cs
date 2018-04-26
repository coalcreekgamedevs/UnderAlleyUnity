using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicBadGuyHealth : MonoBehaviour {

    [SerializeField]
    private int currentHitPoints;
    [SerializeField]
    private int startingHitPoints = 5;

	void Start () {
        currentHitPoints = startingHitPoints;
	}

	public void Update()
	{
		
	}

	public int GetHitPoints()
    {
        return currentHitPoints;
    }

    public void AddHitPoints(int pointsToAdd)
    {
        currentHitPoints += pointsToAdd;
    }

    public void RemoveHitPoints(int pointsToRemove)
    {
        Debug.Log("Removing Hit Points");
        currentHitPoints -= pointsToRemove;

        CheckHitPoints();
    }

    public void CheckHitPoints()
    {
        if(currentHitPoints <= 0)
        {
            Destroy(gameObject);
        }
    }
}
