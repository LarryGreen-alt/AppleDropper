using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyApple : MonoBehaviour
{
 // first declare all the variables
 //private GameObject object; // object to spawn
 private Transform spawn; // object it spawns at
 public int waitTime = 3; // time objects waits till it gets destroyed
 public Rigidbody2D backup;
 
 void Start() {
    Spawn(); // you can't use corroutines in the Start and Update function so we
 // call a new function in order to use Yield WaitForSeconds
 
 }


 
 IEnumerator Spawn() {
    Instantiate(backup, spawn.position, spawn.rotation);
 /* Instantiate is used to make object or something else spawn.
 Instantiate(thingtospawn, positionitspawnsat, rotationitspawnin) */
    yield return new WaitForSeconds(waitTime);
 // stops the code for a time and then resumes it but because its a
 // corroutine it can't be in the Update and Start functions
    Destroy(gameObject);
 //destroys the gameobject the script is attached to
 
 }

void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player2" ||
            collision.gameObject.tag == "Player3")
        {
            GameObject.Find("Tree").GetComponent<ScoreKeep>().AddScore(1);
            Destroy(gameObject);
        
    }
 }


    /*
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        
    }
}*/

}
