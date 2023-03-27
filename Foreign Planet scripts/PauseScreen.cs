using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    public string mainMenuScreen;

    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResumeGame()
    {
        GameManager.instance.PauseUnpause();
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting Game");

    }

    public void MainMenu()
    {
        SceneManager.LoadScene(mainMenuScreen);

        Time.timeScale = 1f;
    }

}
