using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawnTarget : MonoBehaviour
{
    public static float timeToDespawn=2f;
    // public static float timeToDespawnStatic = 6f;
    public float currentDespawnTime;

    void Start()
    {
        currentDespawnTime=timeToDespawn;
    }

    void Update()
    {

        if(currentDespawnTime <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            currentDespawnTime -= Time.deltaTime;
        }
        Debug.Log(currentDespawnTime);
    }
}
