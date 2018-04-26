using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStates : MonoBehaviour {

    public enum States{ MENU, TARGET, ATTACK, DEFENSE }; // DEFENSE is AI ATTACK
    States currentState;

	// Use this for initialization
	void Start () {
        currentState = States.MENU;
	}
	
    public void SetState(States newState)
    {
        currentState = newState;
        Debug.Log("New Menu State: " + newState.ToString());
    }

    public void CallCurrentState()
    {
        switch(currentState)
        {
            case States.MENU:
            // Tell menu its up
                break;

            case States.TARGET:

                break;

            case States.ATTACK:

                break;

            case States.DEFENSE:

                break;

            default:
                Debug.Log("State Not Found");
                break;
        }

    }

    public States GetCurrentState()
    {
        return currentState;
    }
}
