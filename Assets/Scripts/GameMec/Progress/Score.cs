using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;

    public TextMeshProUGUI InGamescoreText;


    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI highScoreText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        InGamescoreText.text = ("Score: " + scoreValue);
        scoreText.text = scoreValue.ToString();


        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        if(PlayerHealth.currentHealth <= 0)
        {
            setHighScore();
        }
    }

    public void setHighScore()
    {
        scoreText.text = scoreValue.ToString();

        if(scoreValue > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", scoreValue);
        }
    }
}
