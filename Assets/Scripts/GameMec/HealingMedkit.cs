using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingMedkit : MonoBehaviour
{
    // Start is called before the first frame update

    public int healthToGive;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            
            other.gameObject.GetComponent<PlayerHealth>().Healing(healthToGive);
            GameObject.Find("MedkitSound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);

        }


            
    }

    
    
       
    
  
}
