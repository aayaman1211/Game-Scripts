using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grouping : MonoBehaviour
{
    Transform player;
    Rigidbody rb;
    public float force = 100;

    public bool startDelay = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        player = GameObject.FindGameObjectWithTag("Player").transform;
        startDelay = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(startDelay == true)
        {
            rb.AddForce((player.position - transform.position).normalized * force);
        }
        
    }
}
