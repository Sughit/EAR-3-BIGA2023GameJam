using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawnTarget : MonoBehaviour
{
    public float timeToDespawn;
    // public static float timeToDespawnStatic = 6f;

    // void Awake()
    // {
    //     timeToDespawn = timeToDespawnStatic;
    // }

    void Update()
    {
        // if(destroyOnClick.score % 5 == 0)
        // {
        //     timeToDespawnStatic -= 0.01f;
        // }
        if(timeToDespawn <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            timeToDespawn -= Time.deltaTime;
        }
    }
}
