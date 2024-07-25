using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static int scor;
    private int highScore ;

    public static Score score = null;

    void Start()
    {
        score = this;
        scor = 0;
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        scoreText = GetComponent<Text>();
        scoreText.text = $"{scor}";
    }

    public void Scored() 
    {
        scor++;
        scoreText.text = $"{scor}";
        if (scor > highScore)
        {
            highScore = scor;
            highScore = PlayerPrefs.GetInt("HighScore", highScore);
        }
    }










    // int score;
    //Text scoreText;
    //int highScore;
    //void Start()
    //{
    //  scoreText = GetComponent<Text>();
    // score = 0;
    // scoreText.text = score.ToString();
    //highScore = PlayerPrefs.GetInt("highscore");

    //}
    //public void Scored()
    //{
    //   score++;
    //  scoreText.text = score.ToString();
    //if (score>highScore)
    //{
    //  highScore = score;
    //PlayerPrefs.SetInt("highscore", highScore);
    //}
    //} 
    //public int GetScore()
    //{
    //  return score;
    //}

}
