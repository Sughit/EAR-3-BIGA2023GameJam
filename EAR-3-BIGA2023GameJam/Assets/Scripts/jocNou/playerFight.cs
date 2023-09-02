using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFight : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpForce = 10f;
    public bool canJump=true;
    public int numOfHits;
    public int numOfHitsLeg;
    public Transform hitPoint;
    public Transform legPoint;
    public Transform downPoint;
    public float attackRange;
    public float attackRangeLeg;
    public float jumpedRange;
    public float damage;
    public float damageLeg;
    public float attackRate;
    public float attackLegRate;
    float currentTime;
    float currentLegTime;
    bool jumped;
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
            jumped = true;
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
            jumped = false;
        }
        if(jumped && (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)))
        {
            jumped = false;
            currentLegTime = attackLegRate;
            JumpAttack();
        }

        Vector3 scale = transform.localScale;
        if(currentTime <= 0)
        {
            if(Input.GetKeyDown(KeyCode.Q))
            {
                currentTime = attackRate;
                scale.x = -1;
                transform.localScale = scale;
                pinguin.SetTrigger("atac");
                
                if(numOfHits == 2)
                {
                    numOfHits=0;
                    SuperAttack();
                }
                else
                {
                    Attack();
                }
            }
        }
        else
        {
            currentTime -= Time.deltaTime;
        }

        if(currentTime <= 0)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                currentTime = attackRate;
                scale.x = 1;
                transform.localScale = scale;
                pinguin.SetTrigger("atac");
                
                if(numOfHits == 2)
                {
                    numOfHits=0;
                    SuperAttack();
                }
                else
                {
                    Attack();
                }
            }
        }
        else
        {
            currentTime -= Time.deltaTime;
        }

        if(Input.GetKey(KeyCode.A))
        {
            scale.x = -1;
            transform.localScale = scale;
            if(currentLegTime <= 0)
            {
                currentLegTime = attackLegRate;
                LegAttack();
                // if(jumped)
                // {
                //     JumpAttack();
                //     jumped = false;
                // }
                // else
                // {
                //     LegAttack();
                // }
            }
            else
            {
                currentLegTime -= Time.deltaTime;
            }
        }
        if(Input.GetKey(KeyCode.D))
        {
            scale.x = 1;
            transform.localScale = scale;
            if(currentLegTime <= 0)
            {
                currentLegTime = attackLegRate;
                LegAttack();
                // if(jumped)
                // {
                //     JumpAttack();
                //     jumped = false;
                // }
                // else
                // {
                //     LegAttack();
                // }
            }
            else
            {
                currentLegTime -= Time.deltaTime;
            }
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
                    numOfHits = 0;
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
                numOfHits++;
                enemy.TakeDamage(damage);
            }
            
        }
    }

    void LegAttack()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(legPoint.position, attackRange))
        {
            if(enemy = collider.GetComponent<enemyHealth>())
            {
                enemy.TakeDamage(damageLeg);
            }
        }
    }

    void JumpAttack()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(downPoint.position, jumpedRange))
        {
            if(enemy = collider.GetComponent<enemyHealth>())
            {
                enemy.TakeDamage(damageLeg + damage/2);
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
        Gizmos.DrawWireSphere(legPosition, attackRangeLeg);

        Gizmos.color = Color.green;
        Vector3 jumpPosition = downPoint.position;
        Gizmos.DrawWireSphere(jumpPosition, jumpedRange);
    }

    public IEnumerator GravityOnOff()
    {
        rb.velocity=new Vector2(0, 0);
        rb.gravityScale = 0.0f;
        yield return new WaitForSeconds(0.2f);
        rb.gravityScale = 8.0f;
    }

}
