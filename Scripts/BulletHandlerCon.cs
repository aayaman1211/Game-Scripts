using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletHandlerCon : MonoBehaviour
{
    public GameObject bullet;
    public GameObject missile;

    public float launchSpeed = 75.0f;
    public float missileLaunchSpeed = 30f;

    public float ammo = 10f;

    public int ammoPickUp = 5;

    public float delay = 0.4f;
    
    public ParticleSystem spark;
    public ParticleSystem missileExp;

    public bool isMissile = false;

    public AudioSource fire;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delay -= Time.deltaTime;
        if (delay <= 0 && isMissile == false)
        {
            if (Input.GetKeyDown(KeyCode.Joystick2Button5) && ammo > 0)
            {
                SpawnObject();
                delay = 0.4f;
            }

        }
        if (isMissile == true)
        {
            if (Input.GetKeyDown(KeyCode.Joystick2Button5))
                SpawnMissile();
        }
    }
    

    void SpawnObject()
    {
        Vector3 spawnPos = transform.position;
        Quaternion spawnRot = Quaternion.identity;

        Vector3 localXDirection = transform.TransformDirection(Vector3.forward);
        Vector3 velocity = localXDirection * launchSpeed;

        GameObject newObject = Instantiate(bullet, spawnPos, spawnRot);

        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        rb.velocity = velocity;
        ammo--;
        spark.Play();
        fire.Play();
    }

    void SpawnMissile()
    {
        Vector3 spawnPos = transform.position;
        Quaternion spawnRot = Quaternion.identity;

        Vector3 localXDirection = transform.TransformDirection(Vector3.forward);
        Vector3 velocity = localXDirection * missileLaunchSpeed;

        GameObject newObject = Instantiate(missile, spawnPos, spawnRot);

        Rigidbody rb = newObject.GetComponent<Rigidbody>();
        rb.velocity = velocity;
        missileExp.Play();
        isMissile = false;
    }
}
