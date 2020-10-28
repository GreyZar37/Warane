using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{


    public GameObject bulletPrefab;
    public Transform firePoint;
    public float bulletForce = 20f;

 

    private void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    public void shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

    }
}