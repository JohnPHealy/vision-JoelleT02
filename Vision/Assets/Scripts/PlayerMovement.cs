using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;
    public Rigidbody2D RB;
    public Animator animator;
    private Vector2 movement;

    public bool canMove;

    // Update is called once per frame
    void Update()
    {
        if (!canMove)
        {
            return;
        }
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);

    }

    private void FixedUpdate()
    {
        RB.MovePosition(RB.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}