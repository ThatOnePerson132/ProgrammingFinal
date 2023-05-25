using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public SpriteRenderer sr;
    public Rigidbody2D rb;
    public float moveSpeed;
    public float horizontalInput;
    public GameManager gm;
    public Animator animator;
    public float ballThrow;
    public float ballThrowDelay;
    public bool canThrow = true;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * moveSpeed * horizontalInput * Time.deltaTime);
        animator.SetFloat("moveSpeed", Mathf.Abs(horizontalInput));
        if (horizontalInput <= 0)
        {
            sr.flipX = true;
        }
        else if (horizontalInput >= 0)
        {
            sr.flipX = false;
        }
    }
    
}
