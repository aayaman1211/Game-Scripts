using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public int damage = 30;

    public bool damageEnemy, damagePlayer;



   

    public void OnTriggerEnter(Collider other)
    {
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
