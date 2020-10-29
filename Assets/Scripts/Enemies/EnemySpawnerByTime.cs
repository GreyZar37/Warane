using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnerByTime : MonoBehaviour
{

    public float spawnRadius = 7, time = 1.5f;
    public GameObject enemy;

    public float startTheGameTimer = 5f;

    float currentTimer;
    public float cooldownTimer;

    void Start()
    {


    }

    private void Update()

    {
        startTheGameTimer -= Time.deltaTime;

        if (startTheGameTimer <= 0)
        {
            startTheGameTimer = 0;
        }

        if (startTheGameTimer == 0)
        {
            currentTimer -= Time.deltaTime;
            if(currentTimer <= 0)
            {
                currentTimer = 0;
            }
            if (currentTimer == 0)
            {
                SpawnAnEnemy();
                currentTimer = cooldownTimer;                 
            }
        }
       
    }

    public void SpawnAnEnemy()
    {
        Vector2 spawnPos = GameObject.Find("Player").transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(enemy, spawnPos, Quaternion.identity);   

    }
   
}
