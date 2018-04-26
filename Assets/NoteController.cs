using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NoteController : MonoBehaviour {

    public RectTransform notePanel;
    public Text textUI;
    private Vector2 normalSize;
    private bool isNoteShowing = false;

    [SerializeField]
    private float minDisplayTime = 2.5f;
    private float displayTimer = 0;
    private bool isDisplayed = false;

	// Use this for initialization
	void Start () {
        normalSize = notePanel.localScale;
        HideNote();
	}

    void ResetTimer()
    {
        displayTimer = minDisplayTime + Time.time;
        isDisplayed = true;
    }

	
	// Update is called once per frame
	void Update () {
        if(isNoteShowing)
        {
            if(Input.anyKey && !isDisplayed)
            {
               HideNote();
            }

        }

        if(isDisplayed)
        {
            if(TimeIsUp())
            {
                isDisplayed = false;
            }
        }

	}

    private bool TimeIsUp()
    {
        if(Time.time > displayTimer)
        {
            return true;
        }
        return false;

    }

    private void HideNote()
    {
        notePanel.localScale = Vector2.zero;
    }

    public void SetNoteText(string newText)
    {
        textUI.text = newText;
    }

    public void ShowNote()
    {
        Debug.Log("SHowing NOte");
        isNoteShowing = true;
        notePanel.localScale = normalSize;

        ResetTimer();
        // transform.localScale = new Vector3(1, 1, 1);
    }

}
