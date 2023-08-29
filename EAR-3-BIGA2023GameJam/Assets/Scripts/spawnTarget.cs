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
                if(timeToSpawn>=0.4f)
                {
                    timeToSpawn-=0.06f;
                }
            }
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
}
