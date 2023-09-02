using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public GameObject textDamage;
    public float isHit;
    SpriteRenderer m_SpriteRenderer;
    Color m_NewColor;
    Color m_Color;
    Rigidbody2D rb;
    public Transform player;
    Animator anim;

    void Awake()
    {
        rb=GetComponent<Rigidbody2D>();
        health = maxHealth;
        m_SpriteRenderer = GetComponent<SpriteRenderer>();
        m_Color= new Color(255, 255, 255);
        m_NewColor = new Color(153, 0, 0);
        anim=GetComponent<Animator>();
    }
    public void TakeDamage(float damage)
    {
        isHit = 1;
        health -= damage;
        anim.SetTrigger("lovit");
        if(transform.position.x - player.position.x < 0)
        {
          Transform(-2);
        } else
        {
            Transform(2);
        }
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
        StartCoroutine(ColorChange());
    }
    void Update()
    {
        isHit -= Time.deltaTime;
        if(health <= 0)
        {
            scoreSystem.score += 50;
            Destroy(gameObject);
        }
    }
    IEnumerator ColorChange()
    {
        m_SpriteRenderer.color = m_NewColor;
        yield return new WaitForSeconds(0.2f);
        m_SpriteRenderer.color = m_Color;
    }
    void Transform(float power)
    {
        for(int i=150;i>=0;i--)
        {
            while(i!=0)
            {
            transform.position += transform.right * power * Time.deltaTime ;
            }
        }
    }

    
}
