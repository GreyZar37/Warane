using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerHealth.playerIsDead == true)
        {
            SceneManager.LoadScene(1);
            PlayerHealth.playerIsDead = false;

            Score.scoreValue = 0;
        }
    }


    public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    
    public void exit()
    {
        Application.Quit();
    }




}
