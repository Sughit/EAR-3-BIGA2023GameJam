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
    public Sprite[] heartStages;

    int index0 = 0;
    int index1 = 0;
    int index2 = 0;
    int index3 = 0;
    int index4 = 0;

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
        // switch(Health)
        // {
        //     case 5:
        //     foreach(var heart in hearts)
        //     {
        //         heart.gameObject.SetActive(true);
        //     }
        //     break;

        //     case 4:
        //     foreach(var heart in hearts)
        //     {
        //         heart.gameObject.SetActive(true);
        //     }
        //     hearts[4].gameObject.SetActive(false);
        //     break;

        //     case 3:
        //     foreach(var heart in hearts)
        //     {
        //         heart.gameObject.SetActive(true);
        //     }
        //     hearts[4].gameObject.SetActive(false);
        //     hearts[3].gameObject.SetActive(false);
        //     break;

        //     case 2:
        //     foreach(var heart in hearts)
        //     {
        //         heart.gameObject.SetActive(true);
        //     }
        //     hearts[4].gameObject.SetActive(false);
        //     hearts[3].gameObject.SetActive(false);
        //     hearts[2].gameObject.SetActive(false);
        //     break;

        //     case 1:
        //     foreach(var heart in hearts)
        //     {
        //         heart.gameObject.SetActive(true);
        //     }
        //     hearts[4].gameObject.SetActive(false);
        //     hearts[3].gameObject.SetActive(false);
        //     hearts[2].gameObject.SetActive(false);
        //     hearts[1].gameObject.SetActive(false);
        //     break;

        //     case 0:
        //     foreach(var heart in hearts)
        //     {
        //         heart.gameObject.SetActive(true);
        //     }
        //     hearts[4].gameObject.SetActive(false);
        //     hearts[3].gameObject.SetActive(false);
        //     hearts[2].gameObject.SetActive(false);
        //     hearts[1].gameObject.SetActive(false);
        //     hearts[0].gameObject.SetActive(false);
        //     break;
        // }
        
    }
    public void Heal(int amount)
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

    public void Damage(int amount)
    {
        Health += amount;
        if(Health <= 25 && Health >20)
        {
            ModifyHeart(4, index0);
            index0++; 
        }
        else if(Health <= 20 && Health >15)
        {
            ModifyHeart(3, index1);
            index1++; 
        }
        else if(Health <= 15 && Health >10)
        {
            ModifyHeart(2, index2);
            index2++; 
        }
        else if(Health <= 10 && Health >5)
        {
            ModifyHeart(1, index3);
            index3++; 
        }
        else if(Health <= 5 && Health >=0)
        {
            ModifyHeart(0, index4);
            index4++;
        }
    }

    void ModifyHeart(int numOfHeart, int i)
    {
        hearts[numOfHeart].sprite = heartStages[i];
    }
}
