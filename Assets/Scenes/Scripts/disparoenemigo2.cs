using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparoenemigo2 : MonoBehaviour
{

    private float waitedTime;

    public float waitTimeToAttack = 3;

    public GameObject Balaenemigo;

    public Transform SpainPoint;

    private void Start() 
    {
       waitedTime = waitTimeToAttack;
    }

    private void Update() 
    {
        if (waitedTime<=0)
        {
            waitedTime = waitTimeToAttack;
            Invoke("LaunchBullet", 0.5f);
        }
        else
        {
            waitedTime -= Time.deltaTime;
        }
    }
    public void LaunchBullet()
      {
        GameObject newBullet;

        newBullet = Instantiate(Balaenemigo);
      }
}



