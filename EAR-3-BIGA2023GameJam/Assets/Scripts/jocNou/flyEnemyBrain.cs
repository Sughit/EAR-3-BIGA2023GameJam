using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flyEnemyBrain : MonoBehaviour
{
    public Transform player;
    public float speed;
    public int damage;
    private bool toRight;
    public Transform attackPoint;
    public float attackRange;
    health playerHealth;

    void Awake()
    {
        if(transform.position.x - player.position.x < 0)
        {
            transform.localScale = new Vector3(1,1,1);
            toRight = true;
        }
        else if(transform.position.x - player.position.x >= 0)
        {
            transform.localScale = new Vector3(-1,1,1);
            toRight = false;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player")
        {
            //animatii
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(toRight)
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }
        else
        {
            transform.position += -transform.right * speed * Time.deltaTime;
        }

        foreach(Collider2D collider in Physics2D.OverlapCircleAll(attackPoint.position, attackRange))
        {
            if(playerHealth = collider.GetComponent<health>())
            {
                if(collider.gameObject.tag=="Player")
                {
                    playerHealth.Damage(-damage);
                    //animatii
                    Destroy(gameObject);
                }
            }else if(collider.gameObject.tag == "Obstacle")
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Vector3 position = attackPoint.position;
        Gizmos.DrawWireSphere(position, attackRange);
    }
}
