using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour

{

    public GameObject endMenu;
    public GameObject inGameCanvas;

    public GameObject returnButton;
    public GameObject resumeButton;

    private float delayTimer = 1f;

    public static bool isPaused;

    public GameObject optionMenu;
    public GameObject gameOverCanvas;

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


        if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false && PlayerHealth.currentHealth > 0)
        {
            Time.timeScale = 0;
            isPaused = true;
            optionMenu.SetActive(true);

        }
        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == true && PlayerHealth.currentHealth > 0)
        {
            Time.timeScale = 1;
            isPaused = false;
            optionMenu.SetActive(false);
        }

        else if (Input.GetKeyDown(KeyCode.Escape) && isPaused == false && PlayerHealth.currentHealth <= 0)
        {
            optionMenu.SetActive(false);

            returnButton.SetActive(false);
            resumeButton.SetActive(true);

            gameOverCanvas.SetActive(true);
        }



    }



    public void startGame()
    {
        SceneManager.LoadScene(1);
    }


    public void resumeGame()
    {
        isPaused = false;
        Time.timeScale = 1;
        optionMenu.SetActive(false);
    }

    public void back()
    {
        optionMenu.SetActive(false);

        returnButton.SetActive(false);
        resumeButton.SetActive(true);

        gameOverCanvas.SetActive(true);
    }

    public void optionMenuShow()
    {
        optionMenu.SetActive(true);

        returnButton.SetActive(true);
        resumeButton.SetActive(false);

        gameOverCanvas.SetActive(false);
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
