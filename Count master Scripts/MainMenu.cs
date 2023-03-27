using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public string Game;
    public string Menu;
    public string Level2;

    public PlayerSpawner ps;
    public Text rem;

    public GameObject aboutpage;
    public GameObject mainmenupage;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rem.text = ("" + ps.noOfPlayers);
    }

    public void Play()
    {
        SceneManager.LoadScene(Game);
    }

    public void Play2()
    {
        SceneManager.LoadScene(Level2);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Mainmenu()
    {
        SceneManager.LoadScene(Menu);
    }

    public void AboutPage()
    {
        aboutpage.SetActive(true);
        mainmenupage.SetActive(false);
    }
    public void ExitAboutPage()
    {
        aboutpage.SetActive(false);
        mainmenupage.SetActive(true);
    }
}
