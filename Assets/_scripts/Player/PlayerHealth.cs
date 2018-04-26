using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    [SerializeField]
    private int currentHitPoints;
    [SerializeField]
    private int startingHitPoints = 5;

    void Start()
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
        currentHitPoints -= pointsToRemove;
    }
}
