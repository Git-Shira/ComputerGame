using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class NavMeshScript : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;

    private bool hasReachedAmy = false; // Flag to track if Suzy has reached Amy


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {// Check if a collision with the player has occurred

        if (!hasReachedAmy)
        {
            agent.SetDestination(target.position);

            // Check if Suzy has reached Amy
            if (Vector3.Distance(transform.position, target.position) <= agent.stoppingDistance)
            {
                    hasReachedAmy = true;

                    LoadLossScene(); // Load the loss scene once Suzy reaches Amy
                
            }
        }
    }

    void LoadLossScene()
    {

        SceneManager.LoadScene(3); // Load the loss scene
    }
}
