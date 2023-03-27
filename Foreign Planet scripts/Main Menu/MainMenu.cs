using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour

{
    public string firstLevel;

    public GameObject continuebutton;

    public GameObject optionscreen;

    public string howtoplay; public string start;



    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("CurrentLevel"))
        {
            if(PlayerPrefs.GetString("CurrentLevel") == "")
            {
                continuebutton.SetActive(false);
            }
        }
        else
        {
            continuebutton.SetActive(false);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame()
    {
        SceneManager.LoadScene(firstLevel);

        PlayerPrefs.SetString("CurrentLevel", "");

        PlayerPrefs.SetString(firstLevel + "_cp", "");

        Cursor.lockState = CursorLockMode.Locked;


        Time.timeScale = 1f;
    }

    


    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quiting Game");


            
    }


    public void HowToPlay()
    {
        SceneManager.LoadScene(howtoplay);
    }

    public void Options()
    {
        optionscreen.SetActive(true);
    }

    public void CloseOptions()
    {
        optionscreen.SetActive(false);
    }


    public void Continue()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("CurrentLevel"));
    }
    public void StartGame()
        
    {
        SceneManager.LoadScene(start);
    }

   

    


}
