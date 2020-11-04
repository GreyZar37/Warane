using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollowMele: MonoBehaviour
{

    public float speed;
    public Transform target;
    private Rigidbody2D rb;
    private Vector2 movement;

    public float coolDown;
    float coolDownTimer;

    public int distence;

   


    void Start()
    {
         rb = this.GetComponent<Rigidbody2D>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

   
    void Update()
    {


        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
        if (coolDownTimer <= 0)
        {
            coolDownTimer = 0;
        }

       
        Vector2 direction = new Vector2(target.position.x - transform.position.x, target.position.y - transform.position.y);
        transform.up = direction;

        if (Vector2.Distance(transform.position, target.position) > distence)
        {

            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }





    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if(coolDownTimer == 0)
        {
            if(other!=null)
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(15);
            coolDownTimer = coolDown;
        }
        
        
    }

}
