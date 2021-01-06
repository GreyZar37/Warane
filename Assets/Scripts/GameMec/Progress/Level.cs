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

    public int xpNeeded = 50;
    public float currentXp = 0;
    public int level = 0;



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        xpNeeded = PlayerPrefs.GetInt("xpNeeded", 0);
        currentXp = PlayerPrefs.GetFloat("currentXp", 0);
        level = PlayerPrefs.GetInt("level", 0);

        if (PlayerHealth.currentHealth == 0)
        {
            currentXp = Score.scoreValue;
        }

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


            if (level >= 1 && level < 10)
            {
                xpNeeded += 50;
            }

            if (level >= 10 && level < 30)
            {
                xpNeeded += 70;
            }
            if (level >= 30 && level < 50)
            {
                xpNeeded += 120;
            }
            if (level >= 70 && level < 100)
            {
                xpNeeded += 150;
            }

            PlayerPrefs.SetInt("xpNeeded", xpNeeded);
            PlayerPrefs.SetFloat("currentXp", currentXp);
            PlayerPrefs.SetInt("level", level);
        }

    }
}
