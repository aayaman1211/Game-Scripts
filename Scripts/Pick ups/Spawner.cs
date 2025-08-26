using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    //Health
    public GameObject Health;
    public int noOfHealth;

    //Ammo
    public GameObject Ammo;
    public int noOfAmmo;

    //Missile
    public GameObject Missile;
    public int noOfMissile;

    //Sheild
    public GameObject Sheild;
    public int noOfSheild;

    public float spawnTimer = 14f;


    // Start is called before the first frame update
    void Start()
    {
        //Health
        noOfHealth = Random.Range(1, 3);
        for (int i = 0; i <= noOfHealth; i++)
        {
            Vector3 randomizeHealthPosition = new Vector3(Random.Range(-21, 28), 3, Random.Range(33, -12));
            Quaternion randomizeHealthRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(Health, randomizeHealthPosition, randomizeHealthRotation);
        }

        //Ammo
        noOfAmmo = Random.Range(1, 3);
        for (int i = 0; i <= noOfAmmo; i++)
        {
            Vector3 randomizeAmmoPosition = new Vector3(Random.Range(-21, 28), 3, Random.Range(33, -12));
            Quaternion randomizeAmmoRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(Ammo, randomizeAmmoPosition, randomizeAmmoRotation);
        }

        //Missile
        noOfMissile = Random.Range(0, 1);
        for (int i = 0; i <= noOfMissile; i++)
        {
            Vector3 randomizeMissilePosition = new Vector3(Random.Range(-21, 28), 3, Random.Range(33, -12));
            Quaternion randomizeMissileRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(Missile, randomizeMissilePosition, randomizeMissileRotation);
        }

        //Sheild
        noOfSheild = Random.Range(0, 1);
        for (int i = 0; i <= noOfMissile; i++)
        {
            Vector3 randomizeSheildPosition = new Vector3(Random.Range(-21, 28), 3, Random.Range(33, -12));
            Quaternion randomizeSheildRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
            Instantiate(Sheild, randomizeSheildPosition, randomizeSheildRotation);
        }
    }
    // Update is called once per frame
    void Update()
    {
        int a = 1;
        spawnTimer -= Time.deltaTime;
        if(spawnTimer < 0)
        {
            //Health
            noOfHealth = Random.Range(1, 3);
            for (int i = 0; i <= noOfHealth; i++)
            {
                Vector3 randomizeHealthPosition = new Vector3(Random.Range(-21, 28), 3, Random.Range(33, -12));
                Quaternion randomizeHealthRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
                Instantiate(Health, randomizeHealthPosition, randomizeHealthRotation);
            }

            //Ammo
            noOfAmmo = Random.Range(1, 3);
            for (int i = 0; i <= noOfAmmo; i++)
            {
                Vector3 randomizeAmmoPosition = new Vector3(Random.Range(-21, 28), 3, Random.Range(33, -12));
                Quaternion randomizeAmmoRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
                Instantiate(Ammo, randomizeAmmoPosition, randomizeAmmoRotation);
            }

            //Missile
            noOfMissile = Random.Range(0, 1);
            for (int i = 0; i <= noOfMissile; i++)
            {
                Vector3 randomizeMissilePosition = new Vector3(Random.Range(-21, 28), 3, Random.Range(33, -12));
                Quaternion randomizeMissileRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
                Instantiate(Missile, randomizeMissilePosition, randomizeMissileRotation);
            }

            //Sheild
            noOfSheild = Random.Range(0, 1);
            for (int i = 0; i <= noOfMissile; i++)
            {
                Vector3 randomizeSheildPosition = new Vector3(Random.Range(-21, 28), 3, Random.Range(33, -12));
                Quaternion randomizeSheildRotation = Quaternion.Euler(0, Random.Range(0, 360), 0);
                Instantiate(Sheild, randomizeSheildPosition, randomizeSheildRotation);
            }
            a++;
            spawnTimer = 12 + a;
        }
    }
}
