using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public SpriteRenderer sr;
    public Rigidbody2D rb;
   
    public float moveSpeed;
    /*     
    public float horizontalInput;
    */
    public Transform wallDetector;
    public GameManager gm;
    public Animator animator;
    public float ballThrowDelay;
    public bool canThrow = true;
    public GameObject[] balls;
    public GameObject ballSpawner;


    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        gm = GameObject.Find("GameManager").GetComponent<GameManager>();
        animator = GetComponent<Animator>();
        balls = GameObject.FindGameObjectsWithTag("Ball");
    }

    void Update()
    {
        /*  horizontalInput = Input.GetAxis("Horizontal");
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
        */

        transform.Translate(Vector2.right * Time.deltaTime * moveSpeed);

        if (wallDetector != null)
        {
            RaycastHit2D ground = Physics2D.Raycast(wallDetector.position, Vector2.right, .5f);
            if (ground.collider == true)
            {
                transform.Rotate(0, 180, 0);
            }
        }

        if (Input.GetButtonDown("Jump") && canThrow && gm.ballsremaining >= 1)
        {
            canThrow = false;
            gm.ballsremaining--;
            Instantiate(balls[Random.Range(0,1)], ballSpawner.transform.position, ballSpawner.transform.rotation);
            new WaitForSeconds(ballThrowDelay);
            canThrow = true;
        }
    }
    
}
