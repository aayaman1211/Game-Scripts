using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchMove : MonoBehaviour
{
    public float PlayerMoveSpeed;

    void Start()
    {

    }

    void FixedUpdate()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            Touch touch = Input.GetTouch(i);

            if (touch.position.x < Screen.width / 2)
            {
                transform.Translate(Vector3.left * Time.deltaTime * PlayerMoveSpeed);
            }
            if (touch.position.x > Screen.width / 2)
            {
                transform.Translate(Vector3.right * Time.deltaTime * PlayerMoveSpeed);
            }
        }
    }
}

