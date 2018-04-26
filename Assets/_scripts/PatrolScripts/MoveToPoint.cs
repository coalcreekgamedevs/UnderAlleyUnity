using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPoint : MonoBehaviour {
    public bool repeatWaypoints = true;
    [SerializeField]
    private float speed = 5f;
    public List<Transform> wayPoints;
    private List<Vector2> points;
    public Vector2 currentTarget;
    public float minDistanceToPoint = 0.5f;
    private Vector2 outOfBounds;

    private LineRenderer lineRenderer;

    // Use this for initialization
    void Start()
    {
        points = new List<Vector2>();
        outOfBounds = new Vector2(99, 99);

        foreach (Transform transform in wayPoints)
        {
            points.Add(transform.position);
        }

        if (points.Count > 0)
        {
            currentTarget = points[0];
        }
        else
        {
            currentTarget = outOfBounds;
        }

    }


	
	// Update is called once per frame
	void Update () {

        if(!currentTarget.Equals(outOfBounds))
        {
            Move();
            DrawDebugLines(transform.position, currentTarget);
        }
        else
        {
            if(points.Count < 1)
            {
                Debug.Log("No Points");
            }
        }

        if(HaveReachedCurrentTarget())
        {
            NextTarget();
        }



	}

	private void Move()
	{
        Vector2 position = transform.position;
        // transform.Translate(Vector2.MoveTowards(position, currentTarget, speed * Time.deltaTime));

        transform.position = Vector2.MoveTowards(position, currentTarget, speed * Time.deltaTime);
	}

    private bool HaveReachedCurrentTarget()
    {
        Vector2 position = transform.position;

        if (Vector2.Distance(position, currentTarget) < minDistanceToPoint)
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

    public void AddPoint(Vector2 newPoint)
    {
        points.Add(newPoint);
        if(currentTarget.Equals(outOfBounds))
        {
            currentTarget = newPoint;
        }
    }

    public void RemovePoint(Vector2 oldPoint)
    {
        if(currentTarget.Equals(oldPoint))
        {
            NextTarget();
        }
        points.Remove(oldPoint);
        // TODO check if matches current point, if so bump to next target
    }

    private void NextTarget()
    {
        int indexOfNextTarget = points.IndexOf(currentTarget) + 1;

        // more points
        if(points.Count > indexOfNextTarget)
        {
            currentTarget = points[indexOfNextTarget];
        }
        // start back at the first waypoints
        else
        {
            if(repeatWaypoints)
            {
                currentTarget = points[0];
            }
            else
            {
                currentTarget = outOfBounds; 
            }
        }

    }
}
