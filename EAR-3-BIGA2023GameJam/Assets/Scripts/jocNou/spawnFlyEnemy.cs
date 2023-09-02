using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFlyEnemy : MonoBehaviour
{
    public GameObject flyEnemy;
    public float timeToSpawn;
    float currentTime;
    public GameObject[] spawnPoints;

    void Update()
    {
        if(scoreSystem.score >= 500)
        {
            if(currentTime <= 0)
            {
                if(Random.Range(0,5) == 2)
                {
                    Instantiate(flyEnemy, spawnPoints[Random.Range(0,4)].transform.position, Quaternion.identity);
                }
            }
            else
            {
                currentTime -= Time.deltaTime;
            }
        }
    }
}
