using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CanvasUI : MonoBehaviour
{
    Movement M_player1;
    Player2_M M_player2;

    BulletHandlerKey B_player1;
    BulletHandlerCon B_player2;

    public Image H_P1;
    public Image H_P2;

    public Text A_P1;
    public Text A_P2;

    public Text Player1_Score;
    public Text Player2_Score;

    public GameObject PauseScreen;

    public Slider bagroundMusic;
    public Slider sfxSlider;
    public AudioSource Sfx;
    public AudioSource bag;

    public GameObject settings;
    
    // Start is called before the first frame update
    void Start()
    {
        M_player1 = FindObjectOfType<Movement>();
        M_player2 = FindObjectOfType<Player2_M>();

        B_player1 = FindObjectOfType<BulletHandlerKey>();
        B_player2 = FindObjectOfType<BulletHandlerCon>();
    }

    // Update is called once per frame
    void Update()
    {
        H_P1.fillAmount = M_player1.health / 100;
        H_P2.fillAmount = M_player2.health / 100;

        A_P1.text = B_player1.ammo.ToString();
        A_P2.text = B_player2.ammo.ToString();

        Player2_Score.text = M_player1.Player2_score.ToString(); 
        Player1_Score.text = M_player2.Player1_score.ToString();

        bag.volume = bagroundMusic.value; 
        Sfx.volume = sfxSlider.value;
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Game");
    }
    public void Main()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Resume()
    {
        PauseScreen.SetActive(false);
    }
    public void Settings()
    {
        PauseScreen.SetActive(false);
        settings.SetActive(true);
    }
    public void CancelSettings()
    {
        settings.SetActive(false);
        PauseScreen.SetActive(true);
    }
}
