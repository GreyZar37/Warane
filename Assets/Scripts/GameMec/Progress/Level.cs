using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Level : MonoBehaviour
{

    
    public Slider slider;
    public Image fill;

    public TextMeshProUGUI levelText;

    public int xpNeeded = 30;
    public float currentXp = 0;
    public int level = 0;

    public bool haveHandled;


    // Start is called before the first frame update
    void Start()
    {

        xpNeeded = PlayerPrefs.GetInt("xpNeeded", 0);
        currentXp = PlayerPrefs.GetFloat("currentXp", 0);
        level = PlayerPrefs.GetInt("level", 0);

    }

    // Update is called once per frame
    void Update()
    {

        levelText.text = "Level " + level;

        slider.maxValue = xpNeeded;
        slider.value = currentXp;

     
        if (slider.value == slider.maxValue)
        {

            if (level != 100)
            {
                currentXp -= slider.maxValue;
                slider.value = currentXp;
                level++;
            }


            if (level >= 1 && level < 5)
            {
                xpNeeded += 50;
            }

            if (level >= 10 && level < 15)
            {
                xpNeeded += 70;
            }
            if (level >= 30 && level < 25)
            {
                xpNeeded += 120;
            }
            if (level >= 70 && level < 75)
            {
                xpNeeded += 150;
            }

            
        }

        if (PlayerHealth.currentHealth == 0 && !haveHandled)
        {

            haveHandled = true;
            currentXp += Score.scoreValue;

            PlayerPrefs.SetInt("xpNeeded", xpNeeded);
            PlayerPrefs.SetFloat("currentXp", currentXp);
            PlayerPrefs.SetInt("level", level);
        }

    }
}
