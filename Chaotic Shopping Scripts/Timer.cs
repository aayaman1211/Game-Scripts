using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public int timeLeft = 60;
    private float timertospeedtimer;

    public Text countDown;

    public int score = 0;

    public Text scoreText;

    public GameObject gameend;
    public GameObject winScreen;
    public Text scoreTextOverall;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("LoseTime");
    }

    // Update is called once per frame
    void Update()
    {
        timertospeedtimer += Time.deltaTime;
        countDown.text = ("" + timeLeft);

        scoreText.text = (" " + score);

        if (timeLeft <= 0)
        {
            countDown.text = ("over");
            
            gameend.SetActive(true);
        }

        //Checking if Bread Task is true

       

        //Checking if Milk Task is True

        
    }

    IEnumerator LoseTime()
    {
        while(true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;

            if(timertospeedtimer >= 70)
            {
                yield return new WaitForSeconds(1/2);
                timeLeft--;
            }

            if(timertospeedtimer >= 130)
            {
                yield return new WaitForSeconds(1/3);
                timeLeft--;
            }
        }

        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(timeLeft <= 15)
        {
            if(collision.tag == "Register")
            {
                winScreen.SetActive(true);
                scoreTextOverall.text = (" " + score);
                Time.timeScale = 0;
            }
        }

    }
}
