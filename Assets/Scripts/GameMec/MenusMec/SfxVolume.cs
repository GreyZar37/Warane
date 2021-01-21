using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SfxVolume : MonoBehaviour
{

    public Slider slider;

    public float sliderValueSFX;

    

    public GameObject audioSourceAmmo;
    public GameObject audioSourceHealth;
    public GameObject audioSourceDeath;
    public GameObject audioSourceShoots;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("SFXVolume", 0);
    }

    // Update is called once per frame
    void Update()
    {

        

        sliderValueSFX = slider.value;

     
        audioSourceAmmo.GetComponent<AudioSource>().volume = sliderValueSFX;
        audioSourceHealth.GetComponent<AudioSource>().volume = sliderValueSFX;
        audioSourceDeath.GetComponent<AudioSource>().volume = sliderValueSFX;

        if (audioSourceShoots != null)
        {
          audioSourceShoots.GetComponent<AudioSource>().volume = sliderValueSFX;
        }

        PlayerPrefs.SetFloat("SFXVolume", sliderValueSFX);

        
    }
}
