using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class health : MonoBehaviour
{
    public int Health;
    public int maxHealth;
    public GameObject gameOver;
    public Image[] hearts;

    void Start()
    {
        Health = maxHealth;
    }
    void Update()
    {
        if(Health <= 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
        switch(Health)
        {
            case 5:
            foreach(var heart in hearts)
            {
                heart.gameObject.SetActive(true);
            }
            break;

            case 4:
            foreach(var heart in hearts)
            {
                heart.gameObject.SetActive(true);
            }
            hearts[4].gameObject.SetActive(false);
            break;

            case 3:
            foreach(var heart in hearts)
            {
                heart.gameObject.SetActive(true);
            }
            hearts[4].gameObject.SetActive(false);
            hearts[3].gameObject.SetActive(false);
            break;

            case 2:
            foreach(var heart in hearts)
            {
                heart.gameObject.SetActive(true);
            }
            hearts[4].gameObject.SetActive(false);
            hearts[3].gameObject.SetActive(false);
            hearts[2].gameObject.SetActive(false);
            break;

            case 1:
            foreach(var heart in hearts)
            {
                heart.gameObject.SetActive(true);
            }
            hearts[4].gameObject.SetActive(false);
            hearts[3].gameObject.SetActive(false);
            hearts[2].gameObject.SetActive(false);
            hearts[1].gameObject.SetActive(false);
            break;

            case 0:
            foreach(var heart in hearts)
            {
                heart.gameObject.SetActive(true);
            }
            hearts[4].gameObject.SetActive(false);
            hearts[3].gameObject.SetActive(false);
            hearts[2].gameObject.SetActive(false);
            hearts[1].gameObject.SetActive(false);
            hearts[0].gameObject.SetActive(false);
            break;
        }
    }
    public void ModifyHealth(int amount)
    {
        if(amount > 0)
        {
            if(Health != maxHealth)
            {
                Health += amount;
            }
        }
        if(amount < 0)
        {
            if(Health != 0)
            {
                Health += amount;
            }
        }
    }
}
