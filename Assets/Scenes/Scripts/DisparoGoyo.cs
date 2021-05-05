using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoGoyo : MonoBehaviour
{
    public Transform FirePoint;
    public GameObject BalaGoyo;


    //Start is called before the first frame update 
    void Start() 
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
       {
          Instantiate(BalaGoyo, FirePoint.position, FirePoint.rotation);
       }
    }
}