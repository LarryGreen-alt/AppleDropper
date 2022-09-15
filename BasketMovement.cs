using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketMovement : MonoBehaviour
{
    public float moveSpeed = 3f;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * Input.GetAxis("Horizontal") * moveSpeed);
    }*/

    // Mouse Control Variabbles
     public float mouseSensitivityX = 1;
     //public float mouseSensitivityY = 1;
     public float initialY = 0.0f; 
     
     // Use this for initialization
     void Start () {
     
     }
     
     // Update is called once per frame
     void Update () {
         
         float moveLR = Input.GetAxis("Mouse X") * mouseSensitivityX * Time.deltaTime;
         //float moveUD = Input.GetAxis("Mouse Y") * mouseSensitivityY * Time.deltaTime;

         
         
        Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
         

        if (mouse.x <= 140.0f && mouse.x >= -140.0f) 
        {

         transform.position = new Vector3(mouse.x , initialY, transform.position.z);

        }
     
     }

     
}
