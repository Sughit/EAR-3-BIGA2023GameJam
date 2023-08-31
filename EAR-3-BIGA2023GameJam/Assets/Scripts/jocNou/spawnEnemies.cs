using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] spawnPoints;
    public float timeToSpawn;
    float currentTime;

    void Start()
    {
        currentTime = timeToSpawn;
    }

    void Update()
    {
        if(Time.timeScale == 1)
        {
            if(currentTime <= 0)
            {
                int random = Random.Range(0,2);
                if(random == 0)
                {
                    Instantiate(enemy,spawnPoints[random].transform.position, Quaternion.identity);
                    currentTime = timeToSpawn;
                }
                else
                {
                    Instantiate(enemy,spawnPoints[1].transform.position, Quaternion.identity);
                    currentTime = timeToSpawn;
                }
            }
            else
            {
                currentTime -= Time.deltaTime;
            }
        }
    }
}
