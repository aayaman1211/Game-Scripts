using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Levelmovement : MonoBehaviour
{
     public Rigidbody rb;

     public float worldBorder = 30f;
     public int currentOffset;

     public float forwardForce = 200f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        currentOffset++;
        if(currentOffset < worldBorder)
        {
            transform.Translate(0, 0, -1);
        }

        //rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
    }

}
