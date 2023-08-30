using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFight : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 10f;
    public int numOfHits;
    public Transform hitPoint;
    public float attackRange;
    public float damage;
    enemyHealth enemy;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce);
        }

        Vector3 scale = transform.localScale;
        if(Input.GetKeyDown(KeyCode.A))
        {
            scale.x = -1;
            transform.localScale = scale;
            Attack();
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            scale.x = 1;
            transform.localScale = scale;
            Attack();
        }
    }

    void Attack()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(hitPoint.position, attackRange))
        {
                if(enemy = collider.GetComponent<enemyHealth>())
                {
                    enemy.TakeDamage(damage);
                }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 position = hitPoint.position;
        Gizmos.DrawWireSphere(position, attackRange);
    }
}
