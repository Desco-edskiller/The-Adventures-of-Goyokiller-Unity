using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Trofeo : MonoBehaviour
{


  private void OnCollisionEnter2D(Collision2D collision) 
 {
   if (collision.transform.CompareTag("Player"))
   {
       Debug.Log("Player Damaged");
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
   }
 }
}