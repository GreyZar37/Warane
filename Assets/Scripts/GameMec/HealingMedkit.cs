using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingMedkit : MonoBehaviour
{
    // Start is called before the first frame update

    public int healthToGive;

    public Animator anim;

    public float selfDestruct = 20;


    public void Update()
    {

        
        selfDestruct -= Time.deltaTime;

        if (selfDestruct <= 5)
        {
            anim.SetBool("DisappearingOnMed", true);


        }

        if (selfDestruct <= 0)
        {
            Destroy(gameObject);
        }

    }

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
