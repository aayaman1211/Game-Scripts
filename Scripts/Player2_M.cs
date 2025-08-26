using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2_M : MonoBehaviour
{
    // PLayer 2 JOYSTICK 2 CON

    BulletHandlerCon B_player2;

    public float moveSpeed = 30f;
    public float rotationSpeed = 120f;

    public GameObject[] leftWheel;
    public GameObject[] rightWheel;

    public float wheelRotationSpeed = 200f;

    private Rigidbody rb;
    private float moveInput;
    private float rotationInput;

    public float health = 100f;

    //Particle
    public ParticleSystem dustLeft;
    public ParticleSystem dustRight;

    //Sheild
    public bool isSheild = false;
    public GameObject Sheild;

    //Point System
    public int Player1_score = 0;

    //Sound
    public AudioSource PickUpSound;
    public AudioSource SheildBreakingSound;
    public AudioSource FireShot;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        B_player2 = FindObjectOfType<BulletHandlerCon>();
    }

    // Update is called once per frame
    void Update()
    {
        SheildBreakingSound.volume = FireShot.volume;
        PickUpSound.volume = FireShot.volume;

        if (health <= 0)
        {
            //Destroy(this.gameObject);
            this.gameObject.SetActive(false);
            Player1_score = Player1_score + 1;
        }

        moveInput = Input.GetAxis("ControllerVertical");
        rotationInput = Input.GetAxis("ControllerHorizontal");

        RotateWheels(moveInput, rotationInput);

        if (Input.GetKey(KeyCode.Joystick2Button4))
            moveSpeed = 15f;
        else
            moveSpeed = 10f;

        if (isSheild == true)
            Sheild.SetActive(true);
        else
            Sheild.SetActive(false);

    }

    private void FixedUpdate()
    {
        MoveTankObj(moveInput);
        RotateTank(rotationInput);
    }

    void MoveTankObj(float input)
    {
        Vector3 moveDirection = transform.forward * input * moveSpeed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDirection);
        if (moveInput > 0)
        {
            dustLeft.Play();
            dustRight.Play();
        }
    }

    void RotateTank(float input)
    {
        float rotation = input * rotationSpeed * Time.fixedDeltaTime;
        Quaternion turnRotation = Quaternion.Euler(0.0f, rotation, 0.0f);
        rb.MoveRotation(rb.rotation * turnRotation);
    }
    void RotateWheels(float moveInput, float rotationInput)
    {
        float wheelRotation = moveInput * wheelRotationSpeed * Time.deltaTime;

        //left
        foreach (GameObject wheel in leftWheel)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(wheelRotation - rotationInput * wheelRotationSpeed * Time.deltaTime, 0.0f, 0.0f);
            }
        }

        foreach (GameObject wheel in rightWheel)
        {
            if (wheel != null)
            {
                wheel.transform.Rotate(wheelRotation + rotationInput * wheelRotationSpeed * Time.deltaTime, 0.0f, 0.0f);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bullet" && isSheild == false)
        {
            health = health - 25;
        }

        if (other.tag == "Missile" && isSheild == false)
        {
            health = health - 100;
        }

        if (health < 100)
        {
            if (other.tag == "Health")
            {
                health = health + 15;
                Destroy(other.gameObject);
                PickUpSound.Play();
            }
        }

        if ((other.tag == "Ammo"))
        {
            B_player2.ammo = B_player2.ammo + B_player2.ammoPickUp;
            Destroy(other.gameObject);
            PickUpSound.Play();
        }

        if (other.tag == "Missile Pick Up")
        {
            B_player2.isMissile = true;
            Destroy(other.gameObject);
            PickUpSound.Play();
        }

        if (other.tag == "Sheild Pick Up")
        {
            isSheild = true;
            Destroy(other.gameObject);
            PickUpSound.Play();
        }

        if (other.tag == "Bullet" && isSheild == true)
        {
            isSheild = false;
            SheildBreakingSound.Play();
        }

        if (other.tag == "Missile" && isSheild == true)
        {
            isSheild = false;
            SheildBreakingSound.Play();
        }
    }
}
