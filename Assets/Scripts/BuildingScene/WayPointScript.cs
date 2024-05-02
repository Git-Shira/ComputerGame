using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPointScript : MonoBehaviour
{
    public Transform[] waypoints;
    public float speed = 5;
    int currentWaypoint;
    Vector3 target, moveDirection;
    private bool flag = true;

    // Update is called once per frame
    void Update()
    {

        target = waypoints[currentWaypoint].position;
        moveDirection = target - transform.position;
        if (moveDirection.magnitude < 1 && flag)
        {
            currentWaypoint = ++currentWaypoint % waypoints.Length;
            StartCoroutine(Stay());
        }
        
        
        GetComponent<Rigidbody>().velocity = moveDirection.normalized * speed;

    }

    IEnumerator Stay()
    {
        flag = false;
        yield return new WaitForSeconds(5);
        flag = true;
    }
}