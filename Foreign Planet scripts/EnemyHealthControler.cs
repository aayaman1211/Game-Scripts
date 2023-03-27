using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthControler : MonoBehaviour
{
    public int currentHealth = 5;
    public EnemyController ec;
    public int noOfEnemys;public int noOfEnemyskilled;
    public BoxCollider gate;
    [SerializeField] private Animator myanim;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DamageEnemy(int damageAmount)
    {
        currentHealth -= damageAmount;

        if(ec != null)
        {
            ec.GetShot();
        }


        if (currentHealth <= 0)
        {
            Destroy(gameObject);

            noOfEnemys -= 1; 

         }

        if(noOfEnemys <= 0)
        {
            gate.enabled = false;
            myanim.SetBool("playanim", true);
            AudioManager.instance.PlaySFX(9);

        }
        



    }



}
