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

    public int index0 = 0;
    public int index1 = 0;
    public int index2 = 0;
    public int index3 = 0;
    public int index4 = 0;

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
            Cursor.visible = true;
        }
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
        else if(Health <= 5 && Health >0)
        {
            ModifyHeart(0, index4);
            index4++;
        }else if(Health == 0)
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
        }
        
    }

    void ModifyHeart(int numOfHeart, int i)
    {
        hearts[numOfHeart].sprite = heartStages[i];
    }
}
