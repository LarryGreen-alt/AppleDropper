using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    private int fails = 0;
    private GameObject body1;
    private GameObject body2;
    private GameObject body3;
    private GameObject tree;

    public void livesLoss()
    {
        ++fails;
        Debug.Log(fails);
        if (fails == 1) {
            Destroy(body1);
        }
        else if (fails == 2) {
            Destroy(body2);
        }
        else if (fails == 3) {
            Destroy(body3);
        }
        if (fails == 3)
        {
            Destroy(tree);
            Application.Quit();
        }
    }

    void Start()
    {
        fails = 0;
        body1 = GameObject.Find("Basket");
        body2 = GameObject.Find("Basket2");
        body3 = GameObject.Find("Basket3");
        tree = GameObject.Find("Tree");
    }

    void Update()
    {

    }



    


}
