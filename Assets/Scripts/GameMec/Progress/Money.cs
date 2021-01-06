using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Money : MonoBehaviour
{
    // Start is called before the first frame update

    public static int money = 0;
    private int scoreAmount;
    int counter = 0;

    public TextMeshProUGUI moneyText;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 

        if (PlayerHealth.currentHealth <= 0)
        {

            
            moneyText.text = "$" + money;


            scoreAmount = Score.scoreValue;

            if(scoreAmount >= 7)
            {
                scoreAmount /= 7;
            }
            else
            {
                scoreAmount = 0;
            }


            if (counter < 1)
            {
                MoneyGen();
                counter++;
            }

            money = PlayerPrefs.GetInt("Money", 0);
        }

    }

    public void MoneyGen()
    {
        money += scoreAmount;
        PlayerPrefs.SetInt("Money", money);

    }
}
