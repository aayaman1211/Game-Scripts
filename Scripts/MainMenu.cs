using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string game;
    public GameObject creditsScreen;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        SceneManager.LoadScene(game);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Credits()
    {
        creditsScreen.SetActive(true);
    }

    public void Cancel()
    {
        creditsScreen.SetActive(false);
    }
}
