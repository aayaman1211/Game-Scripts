using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupingEnemy : MonoBehaviour
{
    Transform enemy;
    Rigidbody rb;
    public float force = 100;

    public bool startDelay = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();

        enemy = GameObject.FindGameObjectWithTag("Enemy").transform;
        startDelay = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (startDelay == true)
        {
            rb.AddForce((enemy.position - transform.position).normalized * force);
        }

    }
}
