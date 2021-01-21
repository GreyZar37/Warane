using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using GameJolt.UI;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;

    public TextMeshProUGUI InGamescoreText;


    public TextMeshProUGUI scoreText;

    public TextMeshProUGUI highScoreText;

    public static string guestName;

    private bool wasSaved = false;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.DeleteAll();
    }

    

    // Update is called once per frame
    void Update()
    {


        InGamescoreText.text = ("Score: " + scoreValue);
        scoreText.text = scoreValue.ToString();
        highScoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();

        if(PlayerHealth.currentHealth <= 0 && wasSaved == false)
        {
      

            GameJolt.API.Scores.Add(PlayerPrefs.GetInt("HighScore", 0), "High Score", guestName, 583080, "", (bool success) => {
                Debug.Log(string.Format("Score Add {0}.", success ? "Successful" : "Failed"));
            });

            wasSaved = true;
            
        }
      

        if (PlayerHealth.currentHealth <= 0)
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
