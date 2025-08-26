using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gamemanager : MonoBehaviour
{
    Movement M_player1;
    Player2_M M_player2;

    public GameObject Player1;
    public GameObject Player2;

    public float regenTimer = 3f;

    public GameObject CutSceneCam;
    private float AnimTimer = 7f;

    public GameObject Player1WinCam;
    public GameObject Player2WinCam;
    
    public GameObject WinScreen;
    public GameObject PauseScreen;

    int pause = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        M_player1 = FindObjectOfType<Movement>();
        M_player2 = FindObjectOfType<Player2_M>();
    }

    // Update is called once per frame
    void Update()
    {
        AnimTimer -= Time.deltaTime;
        if(AnimTimer <= 0)
        {
            CutSceneCam.SetActive(false);
        }


        if(Player1.activeSelf == false)
        {
            regenTimer -= Time.deltaTime;
            if(regenTimer <= 0)
            {
                Player1.SetActive(true);
                M_player1.isSheild = true;
                M_player1.health = 100;
                regenTimer = 3f;
            }
        }
        
        if (Player2.activeSelf == false)
        {
            regenTimer -= Time.deltaTime;
            if (regenTimer <= 0)
            {
                Player2.SetActive(true);
                M_player2.isSheild = true;
                M_player2.health = 100;
                regenTimer = 3f;
            }
        }

        if(pause == 1) 
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button9) || Input.GetKeyDown(KeyCode.Joystick2Button9))
            {
                Debug.Log("Pause");
                PauseScreen.SetActive(true);
                pause = 0;
            }
        }else if(pause == 0)
        {
            if (Input.GetKeyDown(KeyCode.Joystick1Button9) || Input.GetKeyDown(KeyCode.Joystick2Button9))
            {
                Debug.Log("Not Pause");
                PauseScreen.SetActive(false);
                pause = 1;
            }
        }

        if(M_player1.Player2_score == 5 || M_player2.Player1_score == 5)
        {
            if(M_player1.Player2_score > M_player2.Player1_score)
            {
                Debug.Log("Player 2 Won");
                Player2WinCam.SetActive(true);
                Player1.SetActive(false);
                WinScreen.SetActive(true);

            }
            else if(M_player1.Player2_score < M_player2.Player1_score)
            {
                Debug.Log("Player 1 Won");
                Player1WinCam.SetActive(true);
                Player2.SetActive(false);
                WinScreen.SetActive(true);
            }
        }
    }
}
