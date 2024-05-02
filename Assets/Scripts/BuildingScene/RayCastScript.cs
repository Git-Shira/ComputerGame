using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RayCastScript : MonoBehaviour
{


    void Update()
    {
        RaycastHit hit;
        Debug.DrawRay(transform.position, Vector3.right * 5, Color.white);
        if (Physics.Raycast(transform.position, Vector3.right, out hit, 5))
        {
            Debug.Log("Hit");

            if (hit.collider.CompareTag( "Player"))
            {
                SceneManager.LoadScene(11);
            }
        }

    }
}