using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour {
    
    [SerializeField]
    private float speed = 5f;
    public float minDistanceToPoint = 0.5f;
    private Transform playerTransform;

    private LineRenderer lineRenderer;

    // Use this for initialization
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
    }


    // Update is called once per frame
    void Update()
    {
        if(!HaveReachedCurrentTarget())
        {
            Move();
            DrawDebugLines(transform.position, playerTransform.position);
        }

    }

    private void Move()
    {
        Vector2 position = transform.position;
        // transform.Translate(Vector2.MoveTowards(position, currentTarget, speed * Time.deltaTime));

        transform.position = Vector2.MoveTowards(position, playerTransform.position, speed * Time.deltaTime);
    }

    private bool HaveReachedCurrentTarget()
    {
        Vector2 position = transform.position;

        if (Vector2.Distance(position, playerTransform.position) < minDistanceToPoint)
        {
            return true;
        }

        return false;
    }

    private void DrawDebugLines(Vector2 pointA, Vector2 pointB)
    {
        // only shows up in scene view
        Debug.DrawLine(pointA, pointB, Color.green);
    }

}
