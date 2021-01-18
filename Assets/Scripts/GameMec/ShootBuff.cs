using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBuff : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool playerIsBuffed = false;

    public Animator anim;
    

    public float selfDestruct = 15;


    public void Start()
    {
        
    }

    public void Update()
    {
        selfDestruct -= Time.deltaTime;

        if(selfDestruct <= 5)
        {
            anim.SetBool("DisappearingOn", true);
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
            playerIsBuffed = true;
            GameObject.Find("AmmoSound").GetComponent<AudioSource>().Play();
            Destroy(gameObject);
        }




    }



}