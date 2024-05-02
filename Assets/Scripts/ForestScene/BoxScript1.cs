using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxScript1 : MonoBehaviour //Cube
{
    public AudioClip boxSound;
    public GameObject cest;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(boxSound, transform.position);
            cest.GetComponent<Animation>().Play();
            Destroy(gameObject);


            int score = PlayerPrefs.GetInt("score", 0);
            PlayerPrefs.SetInt("victoryScore", score); // Store score in a separate PlayerPrefs key

            SceneManager.LoadScene(8);

        }
    }
}
  