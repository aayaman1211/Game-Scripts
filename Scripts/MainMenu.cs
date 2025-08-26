using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string Game = "Game";
    public GameObject main;
    public GameObject settings;
    public AudioSource MainMenuMusic;
    public Animator Cam;
    public GameObject press;
    public TextMesh Volume;

    public void Update()
    {
        //MainMenuMusic.volume = Music.value;
        Volume.text = (MainMenuMusic.volume * 100).ToString();
        if(Input.GetKeyDown(KeyCode.Joystick1Button0) || Input.GetKeyDown(KeyCode.Joystick2Button0))
        {
            Cam.SetFloat("Hit", 1.1f);
            press.SetActive(false);
            main.SetActive(true);
        }
    }
    public void NewGame()
    {
        SceneManager.LoadScene(Game);
    }

    public void Settings()
    {
        main.SetActive(false);
        settings.SetActive(true);
        Cam.SetFloat("isSettings", 1.1f);
    }

    public void Cancel()
    {
        settings.SetActive(false);
        main.SetActive(true);
        Cam.SetFloat("isSettings", 0f);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void VolumeUp()
    {
        MainMenuMusic.volume = MainMenuMusic.volume + 0.02f;
    } 
    public void VolumeDown()
    {
        MainMenuMusic.volume = MainMenuMusic.volume - 0.02f;
    }

}
