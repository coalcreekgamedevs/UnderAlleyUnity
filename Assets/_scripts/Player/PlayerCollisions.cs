using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisions : MonoBehaviour {

    public NoteController noteController;

    private SceneController sceneController;
    private PlayerWallet playerWallet;
    private PlayerSoundManager playerSoundManager;


	// Use this for initialization
	void Start () {
        sceneController = GameObject.FindWithTag("GameController").GetComponent<SceneController>();
        playerWallet = GameObject.FindWithTag("GameController").GetComponent<PlayerWallet>();
        playerSoundManager = GetComponent<PlayerSoundManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
        Debug.Log("collision");
        if(collision.collider.CompareTag("TreasureBox"))
        {
            TreasureBoxStats treasureBoxStats = collision.gameObject.GetComponent<TreasureBoxStats>();
            playerWallet.AddMoney(treasureBoxStats.GetMoney());
        }

        if (collision.collider.CompareTag("Enemy") || collision.collider.CompareTag("GateKeeper"))
        {
            // save enemy group to playerPrefs
            collision.gameObject.GetComponent<EnemyGroup>().SaveEnemyGroupStats();

            // change scene to battle scene
            sceneController.LoadBattleScene();
        }
 
	}

    private void OnTriggerEnter2D(Collider2D collision)
	{
        Debug.Log("trigger");
        if (collision.CompareTag("Door"))
        {
            DoorTeleportToDoor doorTeleportToDoor = collision.gameObject.GetComponent<DoorTeleportToDoor>();
            if (doorTeleportToDoor)
            {
                transform.position = doorTeleportToDoor.GetOtherDoorPosition();
                playerSoundManager.PlayTeleport();
            }

        }

        Debug.Log("still trigger");

        if(collision.CompareTag("Pickup"))
        {
            playerSoundManager.PlayPickedUpBowlingBall();

            Debug.Log("Pickup");

        }

        if (collision.CompareTag("Note"))
        {
            //               sceneController = GameObject.FindWithTag("GameController").GetComponent<SceneController>();
            // NoteController noteController = GameObject.FindWithTag("GameController").GetComponent<NoteController>();
            if (noteController)
            {
                NoteContent noteContent = collision.GetComponent<NoteContent>();

                if(noteContent)
                {
                    noteController.SetNoteText(noteContent.GetContent());
                    noteController.ShowNote();
                }

            }
            else
            {
                Debug.Log("NotWorking");
            }
        }
	}
}
