using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealthController : MonoBehaviour
{
    public static PlayerHealthController instance;

    public int maxHealth, currentHealth;

    public float invinsiblelenth = 1f;
    private float invinsibleCounter;


    private void Awake()
    {
        instance = this;
    }



    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;

        UIController.instance.healthSlider.maxValue = maxHealth;
        UIController.instance.healthSlider.value = currentHealth;
        UIController.instance.healtText.text = "HEALTH: " + currentHealth + "/" + maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(invinsibleCounter > 0)
        {
            invinsibleCounter -= Time.deltaTime;
        }
    }

    public void DamagePlayer(int damageAmount)
    {
        if (invinsibleCounter <= 0 && !GameManager.instance.levelEnding)
        {
            AudioManager.instance.PlaySFX(7);

            currentHealth -= damageAmount;

            UIController.instance.ShowDamage();


            if (currentHealth <= 0)
            {
                gameObject.SetActive(false);

                currentHealth = 0;
                GameManager.instance.PlayerDied();

                AudioManager.instance.StopBGM();
                AudioManager.instance.PlaySFX(5);
                AudioManager.instance.StopSFX(7);

                ScoreTextScript.coinAmmount = 0;
            }

            invinsibleCounter = invinsiblelenth;

            UIController.instance.healthSlider.value = currentHealth;
            UIController.instance.healtText.text = "HEALTH: " + currentHealth + "/" + maxHealth;
        }

    } 
    
    public void HealPlayer(int healAmount)
    {
        currentHealth += healAmount;

        if(currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }


        UIController.instance.healthSlider.value = currentHealth;
        UIController.instance.healtText.text = "HEALTH: " + currentHealth + "/" + maxHealth;



    }

}
