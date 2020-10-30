using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{


    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;

    float currentTimer;
    public float coolDowntimer;
    public float lowCoolDownTimer;

    public float buffDuration;


    AudioSource gunShotSound;

    private void Start()
    {
        gunShotSound = GetComponent<AudioSource>();
    }


    // Update is called once per frame

    void Update()
    {
        
        if(ShootBuff.playerIsBuffed == true)
        {
            buffDuration -= Time.deltaTime;
        }
        currentTimer -= Time.deltaTime;



        if (currentTimer <= 0)
        {
            currentTimer = 0;
        }

        if (Input.GetButtonDown("Fire1") && currentTimer == 0 && ShootBuff.playerIsBuffed)
        {
            shoot();
            gunShotSound.Play();

            if(ShootBuff.playerIsBuffed == true)
            {
                
                if(buffDuration <= 0)
                {
                    buffDuration = 5;
                    ShootBuff.playerIsBuffed = false;
                    
                }
                else
                {
                    currentTimer = lowCoolDownTimer;
                }
                
            }
            else
            {
                currentTimer = coolDowntimer;
            }
            
        }

        
      
    }

    void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}
