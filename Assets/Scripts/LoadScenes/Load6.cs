using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load6 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // Check if the Enter key is pressed
        if (Input.GetKeyDown(KeyCode.Return))
        {
            // Call the GoToScene method to load scene 6
            GoToScene();
        }
    }

    // Start is called before the first frame update
    public void GoToScene()
    {
        SceneManager.LoadScene(6);
    }
}
