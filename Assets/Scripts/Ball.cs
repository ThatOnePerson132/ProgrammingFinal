using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float lowerLimit;
    public float pointValue;

    public CircleCollider2D cc;

    public Scorezone sz1;
    public BoxCollider2D sz1Collider;
    // Start is called before the first frame update
    void Start()
    {
        pointValue = 5;
        sz1 = GameObject.FindObjectOfType<Scorezone>();
        sz1Collider = sz1.GetComponent<BoxCollider2D>();
        
        cc = gameObject.GetComponent<CircleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowerLimit)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("Scorezone"))
       {
            cc = null;
       }
    }


}
