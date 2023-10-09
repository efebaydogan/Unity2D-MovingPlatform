using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public float speed = 2f;
    public Transform startPoint;
    public Transform finishPoint;

    private Vector3 targetPoint;
    void Start()
    {
        targetPoint = finishPoint.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPoint, speed * Time.deltaTime);

        if(transform.position == targetPoint)
        {
            if(targetPoint == finishPoint.position)
            {
                targetPoint = startPoint.position;
            }
            else
            {
                targetPoint = finishPoint.position;
            }
        }
    }
}