using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeponPickup : MonoBehaviour
{
    
    public string theGun;

    public static bool collected;

    public Text coinamo;

    public static int currency;
    public GameObject text;
    public SphereCollider box;








    public void OnTriggerEnter(Collider other)
    {
        
         
       
         
            if (other.tag == "Player" && !collected)
            {
                PlayerController.instance.AddGun(theGun);

                Destroy(gameObject);

                collected = true;

                AudioManager.instance.PlaySFX(4);

            }

        
       
        
       
       
        





    }
   

}
