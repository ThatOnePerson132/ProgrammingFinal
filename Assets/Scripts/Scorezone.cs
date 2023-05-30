using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorezone : MonoBehaviour
{
    public GameManager gm;

    //public Ball[] balls;
    public Ball ball;

    public bool x1 = true;
    public bool x2 = true;
    public bool x5 = true;
    public bool x10 = true;
    public bool neg5 = true;
    public bool neg10 = true;
    public bool neg15 = true;

    // Start is called before the first frame update
    void Start()
    {
        gm = GameObject.Find("Gamemanager").GetComponent<GameManager>();
        //balls = GameObject.FindObjectsOfType<Ball>();
        ball = GameObject.Find("Ball").GetComponent<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ball") && x1 == true)
        {
            gm.score += ball.pointValue * 1;
        }
        if (collision.gameObject.CompareTag("Ball") && x2 == true)
        {
            gm.score += ball.pointValue * 2;
        }
        if (collision.gameObject.CompareTag("Ball") && x5 == true)
        {
            gm.score += ball.pointValue * 5;
        }
        if (collision.gameObject.CompareTag("Ball") && x10 == true)
        {
            gm.score += ball.pointValue * 10;
        }
        if (collision.gameObject.CompareTag("Ball") && neg5 == true)
        {
            gm.score -= ball.pointValue;
        }
        if (collision.gameObject.CompareTag("Ball") && neg10 == true)
        {
            gm.score -= ball.pointValue * 2;
        }
        if (collision.gameObject.CompareTag("Ball") && neg15 == true)
        {
            gm.score -= ball.pointValue * 3;
        }
    }

}
