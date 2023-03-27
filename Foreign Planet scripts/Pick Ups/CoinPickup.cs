using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickup : MonoBehaviour
{
   

        

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            ScoreTextScript.coinAmmount += 1;
            Destroy(gameObject);
            WeponPickup.currency += 1;
            AudioManager.instance.PlaySFX(8);
        }
      
    }

   








}
