using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScoreScript2 : MonoBehaviour
{
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetInt("score", 0);

        int previousScore = PlayerPrefs.GetInt("score", 0);
        int currentScore = PlayerPrefs.GetInt("victoryScore", 0);

        int totalScore = previousScore + currentScore;

        scoreText.text = "Your Score: " + totalScore.ToString();

        // Store the total score in PlayerPrefs
        PlayerPrefs.SetInt("score", totalScore);

        // Reset the score in PlayerPrefs after retrieving it
        PlayerPrefs.DeleteKey("victoryScore");
        PlayerPrefs.DeleteKey("score");

    }

}
