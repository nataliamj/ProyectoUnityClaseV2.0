
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecking : MonoBehaviour
{

    public static bool isGround;

    

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
            
    }
     public void OnTriggerExit2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = false;
        }
          
    }

}
