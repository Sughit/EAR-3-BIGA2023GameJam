using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;

    void Awake()
    {
        health = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
    }
    void Update()
    {
        if(health == 0)
        {
            Destroy(gameObject);
        }
    }
}
