using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class GroundBreak : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;
    //int counter = 0;
    int countCollisions;
    

    void OnCollisionEnter2D(Collision2D collision){
    
        if (collision.gameObject.tag == "Ground")
        {
           
            Destroy(gameObject);
            GameObject.Find("Hearts").GetComponent<PlayerLives>().livesLoss();
            
            
        }
            

    }


}
        


/*
        if (collision.gameObject.tag == "Ground" && count == 1) 
        {
            ++count;
            Debug.Log(count);
            Destroy(player1);
            //Debug.Log(count);
            ++count;
        }
        

/*
        if (collision.gameObject.tag == "Ground" && count == 2)
        {
            Destroy(gameObject);
            Destroy(player2);
            count = 3;
        }
 
        if (collision.gameObject.tag == "Ground" && count == 3)
        {
            Destroy(gameObject);
            Destroy(player3);
            GameObject.Find("Apple").GetComponent<GameOver>().QuitGame();
        }
    }

    public void AddScore (int newScore) 
    {
        count += newScore;
        
    }
    */
 


