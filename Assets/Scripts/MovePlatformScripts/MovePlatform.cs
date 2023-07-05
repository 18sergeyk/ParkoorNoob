using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField]
    private Transform[] points;
    private int pointsIndex;

    [SerializeField]
    private float speed = 2f;


    void Update()
    {
        if (Vector3.Distance(points[pointsIndex].position, transform.position) < 0.1f)
        {
            pointsIndex++;
            if (pointsIndex >= points.Length)
            {
                pointsIndex = 0;
            }
        }
        transform.position = Vector3.MoveTowards(transform.position, points[pointsIndex].position, Time.deltaTime * speed);
    }

}
