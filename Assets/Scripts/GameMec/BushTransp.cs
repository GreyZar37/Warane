using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BushTransp : MonoBehaviour
{


    SpriteRenderer sprite;


    // Start is called before the first frame update
    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        

    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        sprite.color = new Color(1, 1, 1, 0.6f);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        sprite.color = new Color(1, 1, 1, 1f);
    }

}
