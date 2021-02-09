using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public static int playerDamage;
    
    private void OnTriggerEnter2D(Collider2D other)
    {  
        if (other.tag == "Enemy")

            {

            Destroy(gameObject);
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(playerDamage);

        }
           
    }

   


}
