using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelect : MonoBehaviour
{
    public string firstLevel;
    public string secondLevel;
     public string thirdLevel;
    public string back;
        

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    public void Level1()
    {
        SceneManager.LoadScene(firstLevel);

        PlayerPrefs.SetString("CurrentLevel", "");

        PlayerPrefs.SetString(firstLevel + "_cp", "");

        Cursor.lockState = CursorLockMode.Locked;


        Time.timeScale = 1f;
    }

    public void Level2()
    {
        SceneManager.LoadScene(secondLevel);

        PlayerPrefs.SetString("CurrentLevel", "");

        PlayerPrefs.SetString(firstLevel + "_cp", "");

        Cursor.lockState = CursorLockMode.Locked;


        Time.timeScale = 1f;
    }

    public void Level3()
    {
        SceneManager.LoadScene(thirdLevel);

        PlayerPrefs.SetString("CurrentLevel", "");

        PlayerPrefs.SetString(firstLevel + "_cp", "");

        Cursor.lockState = CursorLockMode.Locked;


        Time.timeScale = 1f;
    }
    public void Back()
    {
        SceneManager.LoadScene(back);
    }




}


