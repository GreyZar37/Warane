using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class MusicVolume : MonoBehaviour
{

    public Slider slider;
    public float sliderValueMusic;



    public GameObject audioSourceMusic;
    

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("MusicVolume", 0);
    }

    // Update is called once per frame
    void Update()
    {



        sliderValueMusic = slider.value;


        audioSourceMusic.GetComponent<AudioSource>().volume = sliderValueMusic;
      

        PlayerPrefs.SetFloat("MusicVolume", sliderValueMusic);


    }
}

