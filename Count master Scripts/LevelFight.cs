using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelFight : MonoBehaviour
{
    public PlayerMovement pm;
    public bool timerOn;
    [SerializeField]private float timer;
    public float timertostop;
    

    // Start is called before the first frame update
    void Start()
    {
        timerOn = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(timerOn == true)
        {
            timer += Time.deltaTime;
            

            if(timer >= timertostop)
            {
                pm.forwardForce = 6000;
                pm.sidewaysForce = 50;
                pm.speedModifier = 0.01f;
                
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            pm.forwardForce = 0;
            pm.sidewaysForce = 0;
            pm.speedModifier = 0;
            timerOn = true;
        }
    }
}
