using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemies : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject enemy;
=======
    public GameObject[] enemy;
>>>>>>> 62873f9ba785cdf8d8734f94791b48395a1028f5
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
<<<<<<< HEAD
                    Instantiate(enemy,spawnPoints[random].transform.position, Quaternion.identity);
=======
                    Instantiate(enemy[Random.Range(0,enemy.Length)],spawnPoints[random].transform.position, Quaternion.identity);
>>>>>>> 62873f9ba785cdf8d8734f94791b48395a1028f5
                    currentTime = timeToSpawn;
                }
                else
                {
<<<<<<< HEAD
                    Instantiate(enemy,spawnPoints[1].transform.position, Quaternion.identity);
=======
                    Instantiate(enemy[Random.Range(0,enemy.Length)],spawnPoints[1].transform.position, Quaternion.identity);
>>>>>>> 62873f9ba785cdf8d8734f94791b48395a1028f5
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
