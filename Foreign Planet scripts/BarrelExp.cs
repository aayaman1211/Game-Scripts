using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelExp : MonoBehaviour
{   

    public GameObject exp;
    public int damage = 30;

    public bool damageEnemy, damagePlayer;


    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Instantiate(exp, transform.position, transform.rotation);

      
        if (other.gameObject.tag == "Enemy" && damageEnemy)
        {
            // Destroy(other.gameObject);
            other.gameObject.GetComponent<EnemyHealthControler>().DamageEnemy(damage);


        }

        if (other.gameObject.tag == "Player" && damagePlayer)
        {
            // Debug.Log("Hit Player at " + transform.position);
            PlayerHealthController.instance.DamagePlayer(damage);
        }

    }

}

   

