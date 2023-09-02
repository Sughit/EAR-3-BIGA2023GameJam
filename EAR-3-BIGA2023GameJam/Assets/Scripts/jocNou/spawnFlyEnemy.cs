using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnFlyEnemy : MonoBehaviour
{
    public GameObject flyEnemy;
    public float timeToSpawn;
    bool coroutineCalled;
    public GameObject[] spawnPoints;

    void Update()
    {
        if(scoreSystem.score >= 500)
        {
            if(!coroutineCalled)
            {
                StartCoroutine(SpawnFlyEnemy());
            }
        }
    }

    IEnumerator SpawnFlyEnemy()
    {
        coroutineCalled = true;
        Instantiate(flyEnemy, spawnPoints[Random.Range(0,4)].transform.position, Quaternion.identity);
        yield return new WaitForSeconds(timeToSpawn);
        coroutineCalled = false;
    }
}
