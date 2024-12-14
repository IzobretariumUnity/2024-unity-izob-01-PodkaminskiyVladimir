using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;



public class PlayerMove : MonoBehaviour
{
    [Header("Constants:")]
    [SerializeField] private Transform groundPoint;
    [SerializeField] private LayerMask groundLayer;

    [Header("Vars:")]
    [SerializeField] private float speed = 7f;
    [SerializeField] private float jumpForse = 8f;

    private Rigidbody2D rigidbody2D;

    private float moveInpt;
    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        rigidbody2D.velocity = MoveVelocity();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Jump();
        }
    }
    private Collider2D Ground()
    {
        return Physics2D.OverlapCircle(groundPoint.position, .01f, groundLayer);
    }

    private void Jump()
    {
        if (Ground())
        {
            rigidbody2D.velocity = Vector2.up * jumpForse;
        }
    }

    private Vector2 MoveVelocity()
    {
        moveInpt = Input.GetAxis("Horizontal");

        return new Vector2(moveInpt * speed, rigidbody2D.velocity.y);
    }

}