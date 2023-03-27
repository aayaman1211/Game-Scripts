using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomize_Task : MonoBehaviour
{
    public GameObject[] RandomTextSpawn;
    public float timerToSpawnText;
    private float timeBetweenSpawns = 0;
    private int randomNo;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeBetweenSpawns -= Time.deltaTime;

        if (timeBetweenSpawns <= 0)
        {
            randomNo = Random.Range(0, RandomTextSpawn.Length);

            for (int i = 0; i <= randomNo; i++)
            {
                if (i != randomNo)
                {
                    RandomTextSpawn[i].SetActive(false);
                }
                else
                {
                    RandomTextSpawn[i].SetActive(true);
                }
            }
            timeBetweenSpawns = timerToSpawnText;
        }
    }
}

/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Randomize_Task : MonoBehaviour
{
    public GameObject[] RandomTextSpawn;
    public float timerToSpawnText;
    private float timeBetweenSpawns = 0;
    private int randomNo;

    // Update is called once per frame
    void Update()
    {
        timeBetweenSpawns -= Time.deltaTime;

        if (timeBetweenSpawns <= 0)
        {
            randomNo = Random.Range(0, RandomTextSpawn.Length);

            for (int i = 0; i <= randomNo; i++)
            {
                if (i == randomNo)
                {
                    RandomTextSpawn[i].SetActive(true);
                }
                else
                {
                    RandomTextSpawn[i].SetActive(false);
                }
            }
            timeBetweenSpawns = timerToSpawnText;
        }
    }
}*/
