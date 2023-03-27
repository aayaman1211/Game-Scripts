using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public float timertohowtoplay;

    public GameObject play1;

    public GameObject play2;

    public GameObject play3;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timertohowtoplay += Time.deltaTime;

        if(timertohowtoplay <= 6)
        {
            play1.SetActive(true);
        }
        if(timertohowtoplay >= 6 && timertohowtoplay <= 12)
        {
            play1.SetActive(false);
            play2.SetActive(true);
        }
        if (timertohowtoplay >= 40 && timertohowtoplay <= 50)
        {
            play1.SetActive(false);
            play2.SetActive(false);
            play3.SetActive(true);
        }
        if (timertohowtoplay >= 13)
        {
            play1.SetActive(false);
            play2.SetActive(false);
            //play3.SetActive(false);
        }
        if (timertohowtoplay >= 50)
        {
            play1.SetActive(false);
            play2.SetActive(false);
            play3.SetActive(false);
        }

    }
}
