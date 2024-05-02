using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static ScoreManagerScript instance;


    public Text scoreText;
  //  public Text hightScoreText;

    int score = 0;
   // int highScore = 0;
    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
      //  highScore = PlayerPrefs.GetInt("highScore", 0);
        //hightScoreText.text = "Best Ever Score " + highScore.ToString();
    }

    // Update is called once per frame
    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " Points";
        PlayerPrefs.SetInt("score", score);

        // if (highScore < score)
        //  PlayerPrefs.SetInt("highScore", score);

    }
}
