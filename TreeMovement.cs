using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 

public class TreeMovement : MonoBehaviour
{
   
     public float delta = 1.5f;  // Amount to move left and right from the start point
     public float speed = 2.0f; 
     public Rigidbody2D fireball;
     public float fireballSpeed = 8f;
     private int randomNumber;
     
     //public bool condition = true;
     
     private Vector3 startPos;

     

 
     void Start () { 
         startPos = transform.position;
         //randomNumber = Random.Range(0, 1000);
         randomNumber = Random.Range(0, 1000);
     }
     


     void Update () {
         Vector3 v = startPos;
         v.x += delta * Mathf.Sin (Time.time * speed);
         transform.position = v;
         

        if (randomNumber <= 10) {
            var fireballInst = Instantiate(fireball, transform.position, Quaternion.Euler(new Vector2(0, 0)));
            fireballInst.velocity = new Vector2(fireballSpeed,0);
            randomNumber = Random.Range(0, 1000);
        }

        randomNumber = Random.Range(0, 1000);

       
         
     }


     
 }