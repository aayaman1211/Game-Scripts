using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateClose : MonoBehaviour
{
    [SerializeField] private Animator myanim1;
    public BoxCollider gate1;

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
            gate1.enabled = true;

            myanim1.SetBool("play", true);

            AudioManager.instance.PlaySFX(9);
        }

    }



}