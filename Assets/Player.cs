using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 4;
    public float jumpForce = 5;
    public int MaxJumps = 2;
    private Rigidbody2D rbody;
    private Animator myAnimator;
    private SpriteRenderer sprite;
    private bool jumpOrder;
    private int jumps = 0;

    public BulletMove direction;

    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            jumps = MaxJumps;
        }
        if (collision.collider.TryGetComponent<ImZombie>(out var yess))
        {
            myAnimator.SetBool("Death", yess);
            myAnimator.SetBool("Dead", yess);
        }
    }
    private void Update()
    {
        jumpOrder |= Input.GetButtonDown("Jump");
    }

    private void FixedUpdate()
    {
        var velocity = rbody.velocity;

        velocity.x = Input.GetAxis("Horizontal") * moveSpeed;
        myAnimator.SetBool("Walk", Input.GetButton("Horizontal"));
        if (Input.GetButton("Horizontal"))
        {
            sprite.flipX = velocity.x < 0;
            direction.direction = velocity.x;
        }

        if (jumpOrder)
        {
            if (jumps > 0)
            {
                jumps -= 1;
                velocity.y = jumpForce;
            }
            jumpOrder = false;
        }

        rbody.velocity = velocity;
    }
}