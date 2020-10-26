using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{

    public float speed;
    public Transform target;
    private Rigidbody2D rb;
    private Vector2 movement;

    public float coolDown;
    public float coolDownTimer;

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
        if(Vector2.Distance(transform.position, target.position) < distence && coolDownTimer == 0)
        {
            gameObject.GetComponent<EnemyShooting>().shoot();
            coolDownTimer = coolDown;
        }


    }

 

}
