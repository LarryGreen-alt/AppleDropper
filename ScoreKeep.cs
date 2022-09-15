using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreKeep : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;
    public int score;
    public int highScore;
    //public int scoreToAdd = 1;


    
    // Start is called before the first frame update
    void Start()
    {
        //score = 0;
        UpdateScore();
    }


    void UpdateScore() 
    {
        //score += scoreToAdd;
        scoreText.text = "Score: " + score;
        //highScoreText.text = "High Score: " + highScore;
        
    }

    public void AddScore (int newScore) 
    {
        score += newScore;
        UpdateScore ();
    }

    //void OnCollisionEnter2D(Collision2D collision)
   // {
   //    if (collision.gameObject.tag == "player") {
   //     score + 1;
   //     }
   //}
    
}
