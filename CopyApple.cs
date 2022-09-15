using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyApple : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] Transform respawnPoint;
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision){
        if (collision.gameObject.tag == "Player" || collision.gameObject.tag == "Player2" ||
            collision.gameObject.tag == "Player3")
        {
            //Instantiate(gameObject);
            collision.gameObject.GetComponent<Rigidbody2D>().position = respawnPoint.position;
        
        }

    
        }
}
