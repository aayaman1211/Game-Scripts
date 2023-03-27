using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{

    public string MenuScreen;

    public float timeBetweenshowing = 1f;

    public GameObject textBox, returnButton;
         


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ShowObjectsCo());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(MenuScreen);
    }

    public IEnumerator ShowObjectsCo()
    {
        yield return new WaitForSeconds(timeBetweenshowing);

        textBox.SetActive(true);
        yield return new WaitForSeconds(timeBetweenshowing);

        returnButton.SetActive(true);
       

    }
         

}
