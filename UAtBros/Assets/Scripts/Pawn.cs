using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pawn : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;

    public LayerMask groundLayer;

    private Rigidbody2D body2D;
    public Animator animator;
    private BoxCollider2D boxCollider2D;


    private void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        boxCollider2D = GetComponent<BoxCollider2D>();
    }

    public void Move(float direction)
    {
        if(direction != 0f)
        {
            

            if(direction < 0)
            {
                direction = -1;
            }
            else if(direction > 0)
            {
                direction = 1;
            }

            Vector3 myScale = transform.localScale;
            myScale.x = direction;
            transform.localScale = myScale;
        }
        else
        {
            //animator.SetBool("isRunning", false);
        }

        Vector3 myPos = transform.position;
        myPos += transform.right * direction * moveSpeed * Time.deltaTime;
        transform.position = myPos;
    }

    public void Jump()
    {
        body2D.velocity = Vector2.up * jumpForce;
        animator.SetBool("isJumping", true);

    }

    public bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast(boxCollider2D.bounds.center, boxCollider2D.bounds.size, 0f, Vector2.down, 0.1f, groundLayer);

        if(hit.collider != null)
        {
            Debug.Log("I AM GROUNDED!!!! NOOOOO!!!!");
            animator.SetBool("isJumping", false);
            return true;
        }
        else
        {
            return false;
        }
    }


}
