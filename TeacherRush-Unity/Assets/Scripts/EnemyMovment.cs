﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovment : MonoBehaviour
{
    public float speed = 6f;
    private Transform target;
    private int waypointIndex = 0;
    
    

    void Start()
    {
        target = Waypoints.points[0];
    }

    void Update()
    {
        Vector3 dir = target.position - transform.position;
        transform.Translate(dir.normalized * speed * Time.deltaTime, Space.World);

        if (Vector3.Distance(target.position, transform.position) <= 0.2f)
        {
            GetNextWaypoint();
        }

        void GetNextWaypoint()
        {
            if (waypointIndex==Waypoints.points.Length-1)
            {
                LifeScript.lifes -= 1;
                Destroy(gameObject);
            }
            else
            {
                waypointIndex++;
                target = Waypoints.points[waypointIndex];   
            }
        }
    }
}
