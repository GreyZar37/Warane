using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public static int maxHealth = 10;
    public  static int currentHealth;

    public HealthBar healthBar;

    public static bool playerIsDead = false;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
        if (currentHealth <= 0)
        {
            playerIsDead = true;
            Destroy(gameObject);
        }

        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }

        print(maxHealth);
    }

   

    

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    public void Healing(int healing)
    {
        currentHealth += healing;
        healthBar.SetHealth(currentHealth);
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
