using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour

{

    public GameObject endMenu;
    public GameObject inGameCanvas;

    private float delayTimer = 1f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (PlayerHealth.playerIsDead == true)
        {
            GameObject[] enemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in enemies)
            GameObject.Destroy(enemy);

        }

        if (PlayerHealth.playerIsDead == true)
        {
            delayTimer -= Time.deltaTime;
            inGameCanvas.SetActive(false);
            if (delayTimer <= 0)
            {   
                endMenu.SetActive(true);
                

                PlayerHealth.playerIsDead = false;
                delayTimer = 0;
            }
            
            
        }


    }


    public void startGame()
    {
        SceneManager.LoadScene(1);
    }

    public void startNewGame()
    {
        SceneManager.LoadScene(1);
        Score.scoreValue = 0;
    }

    public void exit()
    {
        Application.Quit();
    }

   


}
