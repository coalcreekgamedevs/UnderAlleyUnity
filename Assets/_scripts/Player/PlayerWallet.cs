using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWallet : MonoBehaviour 
{

    private int startingAmountOfMoney = 0;
    [SerializeField]
    private int currentMoney;

    private int startingAmountOfExp = 0;
    [SerializeField]
    private int currentExp;

    private static bool created = false;

    void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
            Debug.Log("Awake: " + this.gameObject);
        }
    }

	// Use this for initialization
	void Start () 
    {
        currentMoney = startingAmountOfMoney;
        currentExp = startingAmountOfExp;
	}

    private void SaveToPlayerPrefs()
    {
        PlayerPrefs.SetInt("Money", currentMoney);
        PlayerPrefs.SetInt("Experiance", currentExp);
    }

    private void LoadFromPlayerPrefs()
    {
        currentMoney = PlayerPrefs.GetInt("Money");
        currentExp = PlayerPrefs.GetInt("Experiance");
    }

    public void AddMoney(int amount)
    {
        currentMoney += amount;
    }

    public int GetCurrentMoney()
    {
        return currentMoney;
    }
}
