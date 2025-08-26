using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spin : MonoBehaviour
{
    public float spinSpeed = 90.0f;

    private float moveInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //moveInput = Input.GetAxis("Mouse X");

        if (Input.GetKey(KeyCode.Joystick2Button0))
        {
            transform.Rotate(Vector3.up,-spinSpeed * Time.deltaTime);    
        }

        if (Input.GetKey(KeyCode.Joystick2Button1))
        {
            transform.Rotate(Vector3.up, spinSpeed * Time.deltaTime);
        }
    }
}
