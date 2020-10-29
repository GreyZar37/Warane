using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingMedkit : MonoBehaviour
{
    // Start is called before the first frame update

    public int healthToGive;

    public void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {

            PlayerHealth.currentHealth += healthToGive;
            Destroy(gameObject);
            
        }


            
    }


}
