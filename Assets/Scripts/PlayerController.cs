using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float movementSpeed = 3.0f;
    Vector2 movement = new Vector2();
    Rigidbody2D rigidbody2D;

    Animator animator;
    string animationState = "AnimationState";

    enum States
    {
        right = 1,
        left = 2,
        up = 3,
        down = 4,
        idle = 5
    }
    void Start()
    {
        animator = GetComponent<Animator>();
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateState();
    }

    private void FixedUpdate()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        movement.Normalize();

        rigidbody2D.velocity = movement * movementSpeed;
    }

    private void UpdateState()
    {
        if (movement.x > 0)
        {
            animator.SetInteger(animationState, (int)States.right);
        }
        else if (movement.x < 0)
        {
            animator.SetInteger(animationState, (int)States.left);
        }
        else if (movement.y > 0)
        {
            animator.SetInteger(animationState, (int)States.up);
        }
        else if (movement.y < 0)
        {
            animator.SetInteger(animationState, (int)States.down);
        }
        else
        {
            animator.SetInteger(animationState, (int)States.idle);
        }
    }
}
