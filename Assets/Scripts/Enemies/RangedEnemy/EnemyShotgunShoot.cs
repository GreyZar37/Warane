using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotgunShoot : MonoBehaviour
{


    public GameObject bulletPrefab;
  

    public Transform firePoint;
    public Transform firePointTwo;
    public Transform firePointThree;

    public float bulletForce = 20f;

 

    private void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {


        
    }

    public void shootShotgun()
    {
        GameObject bulletOne = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = bulletOne.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * bulletForce, ForceMode2D.Impulse);

        GameObject bulletTwo = Instantiate(bulletPrefab, firePointTwo.position, firePointTwo.rotation);
        Rigidbody2D rbTwo = bulletTwo.GetComponent<Rigidbody2D>();
        rbTwo.AddForce(firePointTwo.up * bulletForce, ForceMode2D.Impulse);

        GameObject bulletThree = Instantiate(bulletPrefab, firePointThree.position, firePointThree.rotation);
        Rigidbody2D rbThree = bulletThree.GetComponent<Rigidbody2D>();
        rbThree.AddForce(firePointThree.up * bulletForce, ForceMode2D.Impulse);



    }
}