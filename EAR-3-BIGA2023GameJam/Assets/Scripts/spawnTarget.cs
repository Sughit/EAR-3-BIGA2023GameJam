using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTarget : MonoBehaviour
{
    public float timeToSpawn;
    public float currentTime;
    public GameObject[] areaToSpawn;
    public GameObject target;


    void Update()
    {
        if(currentTime <= 0)
        {
            int random = Random.Range(0,areaToSpawn.Length);
            if(areaToSpawn[random].transform.childCount == 0)
            {
                Instantiate(target, areaToSpawn[random].transform);
                currentTime = timeToSpawn;
            }
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
}
