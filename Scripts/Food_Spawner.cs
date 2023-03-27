using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food_Spawner : MonoBehaviour
{
    public List<GameObject> list = new List<GameObject>();

    private float timer;

    private GameObject spawned;

    private float timerToSpeedShitUp;

    public int timerToChange = 10;

   
    
    // Start is called before the first frame update
    void Start()
    {
       
        if (timer == 0)
        {
            int rnd = Random.Range(0, list.Count);
            spawned = Instantiate(list[rnd], transform.position, Quaternion.identity);

        }
            
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        timerToSpeedShitUp += Time.deltaTime;
        

        if (timer >= timerToChange)
        {
            Destroy(spawned);
            timer = 0;
        }

        if (timer == 0)
        {
            int rnd = Random.Range(0, list.Count);
            spawned = Instantiate(list[rnd], transform.position, Quaternion.identity);

        }

        if(timerToSpeedShitUp >= 25 && timerToSpeedShitUp <= 45)
        {
            timerToChange = 8;
        }
        if (timerToSpeedShitUp >= 45 && timerToSpeedShitUp <= 55) 
        {
               timerToChange = 6;
        }
       if(timerToSpeedShitUp >= 55)
        {
            timerToChange = 4;
        }
    }
  
}
