using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnTarget : MonoBehaviour
{
    public float timeToSpawn;
    public float currentTime;
    public GameObject[] areaToSpawn;
    public GameObject target;
    public GameObject targetDown;
    public GameObject targetUp;


    void Update()
    {
        if(currentTime <= 0)
        {
            int random = Random.Range(0,areaToSpawn.Length);
            if(areaToSpawn[random].transform.childCount == 0)
            {
                if(random == 0 || random == 1 || random == 2)
                {
                    Instantiate(targetUp, areaToSpawn[random].transform);
                }
                else if(random == 3 || random == 4)
                {
                    Instantiate(targetDown, areaToSpawn[random].transform);
                }
                else 
                {
                    Instantiate(target, areaToSpawn[random].transform);
                }
                currentTime = timeToSpawn;
                if(timeToSpawn>=0.42f)
                {
                    timeToSpawn-=0.05f;
                }
            }
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }
}
