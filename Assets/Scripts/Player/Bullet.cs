using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    
    private void OnTriggerEnter2D(Collider2D other)
    {  
        if (other.tag == "Enemy")

            {

            Destroy(gameObject);
            other.gameObject.GetComponent<EnemyHealth>().TakeDamage(5);

        }
           
    }

   


}
