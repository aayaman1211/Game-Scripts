using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplyerOfPlayer : MonoBehaviour
{
    public PlayerSpawner playerSpawner;
    private int randomNo;
    public TextMesh multiplyAmount;
    public int lowerMultValue;
    public int higherMultValue;

    // Start is called before the first frame update
    void Start()
    {
        randomNo = Random.Range(lowerMultValue, higherMultValue);
    }

    // Update is called once per frame
    void Update()
    {
        multiplyAmount.text = ("X" + randomNo);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            playerSpawner.noOfPlayers *= randomNo;

        }

        /*if (other.tag == "+50")
        {
            playerSpawner.noOfPlayers += 50;
        }

        if (other.tag == "X3")
        {
            playerSpawner.noOfPlayers *= 3;
        }

        if (other.tag == "+30")
        {
            playerSpawner.noOfPlayers += 30;
        }

        if (other.tag == "X2")
        {
            playerSpawner.noOfPlayers *= 2;
        }*/
    }
}
