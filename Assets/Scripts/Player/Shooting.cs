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

    public float currentbuffDuration;
    public float buffDuration;

   
    


    AudioSource gunShotSound;

    private void Start()
    {
        currentbuffDuration = buffDuration;
        gunShotSound = GetComponent<AudioSource>();

      
    }


    // Update is called once per frame

    void Update()
    {
        
       
        if (ShootBuff.playerIsBuffed == true)
        {
            currentbuffDuration -= Time.deltaTime;
        }
        currentTimer -= Time.deltaTime;



        if (currentTimer <= 0)
        {
            currentTimer = 0;
        }

        if (Input.GetButtonDown("Fire1") && currentTimer == 0 && ShootBuff.playerIsBuffed == false)
        {
            shoot();
            gunShotSound.Play();
            currentTimer = coolDowntimer;
            


        }
        if (Input.GetButton("Fire1") && currentTimer == 0 && ShootBuff.playerIsBuffed == true)
        {
            shoot();
            gunShotSound.Play();
         
         
            currentTimer = lowCoolDownTimer;

            if(currentbuffDuration <= 0)
            {
               
                currentbuffDuration = buffDuration;
                ShootBuff.playerIsBuffed = false;
                


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
