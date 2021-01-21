using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerByScore : MonoBehaviour
{

    public float spawnRadius = 7, time = 1.5f;
    public GameObject enemy;
    public int scoreToSpawn;

    GameObject player;

    float currentTimer;
    public float cooldownTimer;

    void Start()
    {
        player = GameObject.Find("Player");
        
    }

    private void Update()

    {
        


        if (Score.scoreValue >= scoreToSpawn)
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
        if (player != null)
        {
        Vector2 spawnPos = player.transform.position;
        spawnPos += Random.insideUnitCircle.normalized * spawnRadius;
        Instantiate(enemy, spawnPos, Quaternion.identity);
        }
    }
   
}
