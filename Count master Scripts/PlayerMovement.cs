using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     //this is the reference to the Rigidbody component called "rb"
     public Rigidbody rb;

     public float forwardForce = 2000f;
     public float sidewaysForce = 500f;

    private Touch touch;
    public float speedModifier;

    private void Start()
    {
       speedModifier = 0.01f;
       
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        //Add a forward Force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
          rb.AddForce(sidewaysForce * Time.deltaTime,0 ,0, ForceMode.VelocityChange);
		}
        
        if (Input.GetKey("a"))
        {
           rb.AddForce(-sidewaysForce * Time.deltaTime,0 ,0, ForceMode.VelocityChange);
		}
        
        if(Input.touchCount > 0)
        {
            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector3(transform.position.x + touch.deltaPosition.x * speedModifier,transform.position.y, transform.position.z);
                
            }
        }
    
    }
}
