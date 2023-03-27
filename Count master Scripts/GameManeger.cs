using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    public PlayerSpawner ps;
    public GameObject lostScreen;

    // Start is called before the first frame update
    void Start()
    {
        lostScreen.SetActive(false);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(ps.noOfPlayers <= 0)
        {
            Time.timeScale = 0;
            lostScreen.SetActive(true);
        }
    }
}
