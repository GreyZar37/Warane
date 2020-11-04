using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    // Start is called before the first frame update

    public int scoreToBeginWave;
    public int scoreToEndWave;

    public int scoreToBeginWaveTwo;
    public int scoreToEndWaveTwo;



    public GameObject waveSpawner;
    public GameObject waveSpawnerTwo;


    public GameObject SpawnTextOne;
    public GameObject SpawnTextTwo;
 

    public GameObject SpawnCleredTextOne;
    public GameObject SpawnCleredTextTwo;
 
   



    public GameObject spawner;

    public bool waveStarted;
    public bool waveStartedTwo;

    // Update is called once per frame
    void Update()
    {

        if (Score.scoreValue >= scoreToBeginWave)
        {
            waveStarted = true;
        }
        if (Score.scoreValue >= scoreToEndWave)
        {
            waveStarted = false;

        }

        if (waveStarted == true)
        {
            SpawnTextOne.gameObject.SetActive(true);
            spawner.gameObject.SetActive(false);
            waveSpawner.gameObject.SetActive(true);

        }
        else if (waveStarted == false)
        {
            if (Score.scoreValue == scoreToEndWave)
            {
                SpawnCleredTextOne.gameObject.SetActive(true);
                waveSpawner.gameObject.SetActive(false);
                spawner.gameObject.SetActive(true);
                GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject enemy in enemies)
                    GameObject.Destroy(enemy);
            }



        }





        if (Score.scoreValue >= scoreToBeginWaveTwo)
        {
            waveStartedTwo = true;
        }
        if (Score.scoreValue >= scoreToEndWaveTwo)
        {
            waveStartedTwo = false;

        }

        if (waveStartedTwo == true)
        {
            SpawnTextTwo.gameObject.SetActive(true);
            waveSpawnerTwo.gameObject.SetActive(true);
            spawner.gameObject.SetActive(false);

        }
        else if (waveStartedTwo == false && waveStarted == false)
        {
            if (Score.scoreValue >= scoreToEndWaveTwo)
            {
                SpawnCleredTextTwo.gameObject.SetActive(true);
                spawner.gameObject.SetActive(true);
                GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
                foreach (GameObject enemy in enemies)
                    GameObject.Destroy(enemy);
            }
            waveSpawnerTwo.gameObject.SetActive(false);
        }

    }

}
