using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdderOfPlayer : MonoBehaviour
{
    public PlayerSpawner playerSpawner;
    int randomNo;
    public TextMesh addAmount;
    public int lowerAddValue;
    public int higherAddValue;

    // Start is called before the first frame update
    void Start()
    {
        randomNo = Random.Range(lowerAddValue, higherAddValue);
    }

    // Update is called once per frame
    void Update()
    {
        addAmount.text = ("+" + randomNo);
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            
            playerSpawner.noOfPlayers += randomNo;
            
        }

        
    }
}
