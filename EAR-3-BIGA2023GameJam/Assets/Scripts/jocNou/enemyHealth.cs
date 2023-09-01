using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public GameObject textDamage;

    void Awake()
    {
        health = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        health -= damage;
        if(textDamage != null && health != 0)
        {
            ShowDamageText();
        }
    }

    void ShowDamageText()
    {
        var go = Instantiate(textDamage, transform.position, Quaternion.identity);
        go.GetComponent<TextMesh>().text = (maxHealth - health).ToString();
        maxHealth = health;
    }
    void Update()
    {
        if(health <= 0)
        {
            scoreSystem.score += 50;
            Destroy(gameObject);
        }
    }
}
