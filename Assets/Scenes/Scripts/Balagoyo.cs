using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balagoyo : MonoBehaviour
{
    private Rigidbody2D rb2D;
    public float Speed;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       rb2D.velocity = transform.right * Speed; 
       Destroy(gameObject, 5f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
     if (collision.transform.CompareTag("Untagged"))
     {
        Debug.Log("Untagged"); 
        Destroy(collision.gameObject);
     }
    }
}
