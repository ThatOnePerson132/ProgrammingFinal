using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float lowerLimit;
    public float pointValue;

    // Start is called before the first frame update
    void Start()
    {
        pointValue = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < lowerLimit)
        {
            Destroy(gameObject);
        }
    }


}
