using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureBoxDrawOrder : MonoBehaviour
{

    private int startingOrderInLayer = -3;
    private int afterCollisionOrderInLayer = -5;

    private SpriteRenderer sr;

    // Use this for initialization
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        if (sr)
        {
            sr.sortingOrder = startingOrderInLayer;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (sr)
            {
                sr.sortingOrder = afterCollisionOrderInLayer;
            }
        }
    }
}