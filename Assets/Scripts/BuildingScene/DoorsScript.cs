using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorsScript : MonoBehaviour
{
    Animator animator;
    bool doorOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            DoorControl("Open");
            doorOpen = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (doorOpen)
        {
            doorOpen = false;
            DoorControl("Close");
        }
    }
    private void DoorControl(string state)
    {
        animator.SetTrigger(state);
    }
}
