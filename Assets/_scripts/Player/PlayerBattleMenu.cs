using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBattleMenu : MonoBehaviour {

    public Button bowlButton;
    public GameObject BowlAttackSubMenu;
    public Button upTheMiddleButton;

    // Use this for initialization
    void Start()
    {
        bowlButton.onClick.AddListener(BowlButtonClick);
        upTheMiddleButton.onClick.AddListener(UpTheMiddleButtonClick);
    }

    void BowlButtonClick()
    {
        BowlAttackSubMenu.SetActive(true);
    }

    void UpTheMiddleButtonClick()
    {
        Debug.Log("Attack");
    }
}
