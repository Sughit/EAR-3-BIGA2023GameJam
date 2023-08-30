using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFight : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 10f;
    public bool canJump=true;
    public int numOfHits;
    public Transform hitPoint;
    public Transform legPoint;
    public float attackRange;
    public float damage;
    enemyHealth enemy;
    Animator animEnemy;
    Animator pinguin;

    void Start()
    {
        rb=GetComponent<Rigidbody2D>();
        pinguin=GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Ground")
        {
            canJump = true;
        }
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump)
        {
            rb.AddForce(Vector2.up * jumpForce);
            pinguin.SetTrigger("sarit");
            canJump = false;
        }

        Vector3 scale = transform.localScale;
        if(Input.GetKeyDown(KeyCode.Q))
        {
            scale.x = -1;
            transform.localScale = scale;
            pinguin.SetTrigger("atac");
            numOfHits++;
            if(numOfHits == 3)
            {
                SuperAttack();
                numOfHits=0;
            }
            Attack();
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            scale.x = 1;
            transform.localScale = scale;
            pinguin.SetTrigger("atac");
            numOfHits++;
            if(numOfHits == 3)
            {
                SuperAttack();
                numOfHits=0;
            }
            Attack();
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            scale.x = -1;
            transform.localScale = scale;
            numOfHits++;
            if(numOfHits == 3)
            {
                SuperLegAttack();
                numOfHits=0;
            }
            LegAttack();
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            scale.x = 1;
            transform.localScale = scale;
            numOfHits++;
            if(numOfHits == 3)
            {
                SuperLegAttack();
                numOfHits=0;
            }
            LegAttack();
        }

        if(Input.GetKey(KeyCode.D))
        {
            pinguin.SetBool("atac(jos)",true);
        }else if(Input.GetKey(KeyCode.A))
        {
            pinguin.SetBool("atac(jos)",true);

        
        }else
        {
            pinguin.SetBool("atac(jos)",false);
        }
    }

    void SuperAttack()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(hitPoint.position, attackRange))
        {
                if(enemy = collider.GetComponent<enemyHealth>())
                {
                    enemy.TakeDamage(2*damage);
                }
        }
    }

    void SuperLegAttack()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(legPoint.position, attackRange))
        {
                if(enemy = collider.GetComponent<enemyHealth>())
                {
                    enemy.TakeDamage(damage);
                    animEnemy = collider.GetComponent<Animator>();
                    animEnemy.SetTrigger("fall");
                }
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
            else
            {
                numOfHits=0;
            }
        }
    }

    void LegAttack()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(legPoint.position, attackRange))
        {
            if(enemy = collider.GetComponent<enemyHealth>())
            {
                enemy.TakeDamage(damage);
            }
            else
            {
                numOfHits=0;
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 position = hitPoint.position;
        Gizmos.DrawWireSphere(position, attackRange);

        Gizmos.color = Color.blue;
        Vector3 legPosition = legPoint.position;
        Gizmos.DrawWireSphere(legPosition, attackRange);
    }

    public IEnumerator GravityOnOff()
    {
        rb.velocity=new Vector2(0, 0);
        rb.gravityScale = 0.0f;
        yield return new WaitForSeconds(0.2f);
        rb.gravityScale = 8.0f;
    }

}
