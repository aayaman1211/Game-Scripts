using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateOpen : MonoBehaviour
{
    [SerializeField] private Animator myanim;
    public BoxCollider gate;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {




    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gate.enabled = false;

            myanim.SetBool("playanim", true);

            AudioManager.instance.PlaySFX(9);

        }
       
    }
    
 
        

}
