using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{
    public float speed = 4f;
    public float jumpForce = 4f; // Aumentado significativamente
    private Rigidbody2D rb;
    // Changed from Animation to Animator to use SetFloat
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // Changed from Animation to Animator
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        float move = Input.GetAxis("Horizontal");
        float jump = Input.GetAxis("Jump");

        if (jump != 0 && GroundChecking.isGround)
        {
            rb.velocity = new Vector2(0, speed);
        }

        if (move != 0)
        {
            // Changed "Camina" to "Walk" for correct spelling and typical parameter naming
            animator.SetFloat("Walk", move);
            rb.velocity = new Vector2(move * speed, rb.velocity.y);
        }
        
    }
}