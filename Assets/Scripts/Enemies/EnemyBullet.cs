using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour

   
{

    public int damage;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null)
        { 
            
                other.gameObject.GetComponent<PlayerHealth>().TakeDamage(damage);
                Destroy(gameObject);

            
        }
            
       
    }

}
