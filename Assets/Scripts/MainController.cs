using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public float speed = 4f;
    public float jumpForce = 4f; // Aumentado significativamente
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
       
        float move = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");

        if (jump != 0 && GroundChecking.isGround)
        {

            rb.velocity = new Vector2(0, speed);
        }

        if (move!= 0)
        {
            rb.velocity = new Vector2(move * speed, rb.velocity.y);
        }
    }

  
}