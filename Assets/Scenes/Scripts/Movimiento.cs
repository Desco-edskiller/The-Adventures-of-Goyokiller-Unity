using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    
    public float runSpeed=2;

    Rigidbody2D rb2D;



    void Start()
    {
       rb2D = GetComponent<Rigidbody2D>(); 
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey("right"))
        {
            rb2D.velocity= new Vector2(runSpeed, rb2D.velocity.y);
        }
        else if (Input.GetKey("left"))
        {
            rb2D.velocity= new Vector2(-runSpeed, rb2D.velocity.y);
        }
        else
        {
            rb2D.velocity= new Vector2(0, rb2D.velocity.y);
        }
    }
}
