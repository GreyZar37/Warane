using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestoryBullets : MonoBehaviour
{



    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
        
    }
}
