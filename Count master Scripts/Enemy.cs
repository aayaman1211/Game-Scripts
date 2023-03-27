using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerSpawner ps;
    public PlayerMovement pm;

   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(pm.forwardForce == 0 && pm.sidewaysForce == 0)
       {
            gameObject.GetComponent<Grouping>().enabled = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PlayerPawn")
        {
            ps.noOfPlayers--;
            ps.comparer--;
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
