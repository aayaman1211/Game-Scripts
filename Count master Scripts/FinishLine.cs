using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour
{
    public PlayerMovement ps;
    public GameObject winScreen;

    // Start is called before the first frame update
    void Start()
    {
        ps.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        ps.enabled = false; 
        winScreen.SetActive(true);
    }
}
