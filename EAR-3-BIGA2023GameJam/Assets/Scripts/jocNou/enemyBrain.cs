using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBrain : MonoBehaviour
{
    public Transform player;
    public float speed;
    public float stopDis;
    public float attackRange;
    public float attackRate;
    public int damage;
    float currentTime;
    public Transform attackPoint;
    health playerHealth;

    void Update()
    {
        if(transform.position.x - player.position.x < 0)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if(transform.position.x - player.position.x >= 0)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        if(Vector3.Distance(transform.position, player.position) > stopDis)
        {
            if(transform.position.x - player.position.x < 0)
            {
                transform.position += transform.right * speed * Time.deltaTime;
            }else if(transform.position.x - player.position.x >= 0)
            {
                transform.position += -transform.right * speed * Time.deltaTime;
            }
        }
        else if(Vector3.Distance(transform.position, player.position) <= stopDis)
        {
            speed = 0;
            if(currentTime <= 0)
            {
<<<<<<< HEAD
=======
                Debug.Log("atac");
>>>>>>> 62873f9ba785cdf8d8734f94791b48395a1028f5
                Attack();
                currentTime = attackRate;
            }
            else
            {
                currentTime -= Time.deltaTime;
            }
        }
        else
        {
            speed = 4;
        }
    }

    void Attack()
    {
        foreach(Collider2D collider in Physics2D.OverlapCircleAll(attackPoint.position, attackRange))
        {
            if(playerHealth = collider.GetComponent<health>())
            {
<<<<<<< HEAD
                playerHealth.ModifyHealth(damage);
=======
                playerHealth.ModifyHealth(-damage);
>>>>>>> 62873f9ba785cdf8d8734f94791b48395a1028f5
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
