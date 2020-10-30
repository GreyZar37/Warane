using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBuff : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool playerIsBuffed = false;
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            playerIsBuffed = true;
            Destroy(gameObject);
        }




    }



}