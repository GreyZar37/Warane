using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTest : MonoBehaviour
{

    
    public GameObject spawner;
    public GameObject waveSpawner;

    public GameObject spawnText;
    public GameObject spawnCleredText;

    public int scoreToBeginWave;
    public int scoreToEndWave;

    public int __________;

    public GameObject waveSpawnerTwo;

    public GameObject spawnTextTwo;
    public GameObject spawnCleredTextTwo;

    public int scoreToBeginWaveTwo;
    public int scoreToEndWaveTwo;

    public int ___________;

    public GameObject waveSpawnerThree;

    public GameObject spawnTextThree;
    public GameObject spawnCleredTextThree;

    public int scoreToBeginWaveThree;
    public int scoreToEndWaveThree;

    public int wave;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(wave == 2)
        {
            newWave(spawner, waveSpawnerThree, spawnTextThree, spawnCleredTextThree, scoreToBeginWaveThree, scoreToEndWaveThree);
        }
      
        if(wave == 1)
        {
            newWave(spawner, waveSpawnerTwo, spawnTextTwo, spawnCleredTextTwo, scoreToBeginWaveTwo, scoreToEndWaveTwo);
        }
       

        if(wave == 0)
        {
            newWave(spawner, waveSpawner, spawnText, spawnCleredText, scoreToBeginWave, scoreToEndWave);
        }



    }

    void newWave(GameObject spawner, GameObject waveSpawner, GameObject SpawnText, GameObject SpawnCleredText, int scoreToBeginWave, int scoreToEndWave)
    {

        if (Score.scoreValue >= scoreToBeginWave && Score.scoreValue < scoreToEndWave)
        {
            if (SpawnText)
            {
              SpawnText.gameObject.SetActive(true);
            }
            
            spawner.gameObject.SetActive(false);
            waveSpawner.gameObject.SetActive(true);

        }
        else if (Score.scoreValue >= scoreToEndWave)
        {


            if (SpawnCleredText)
            {
                SpawnCleredText.gameObject.SetActive(true);
            }

            waveSpawner.gameObject.SetActive(false);
            spawner.gameObject.SetActive(true);
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);

            wave++;

        }


    }
}
