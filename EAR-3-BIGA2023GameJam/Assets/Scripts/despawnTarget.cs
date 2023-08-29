using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawnTarget : MonoBehaviour
{
    public float timeToDespawn;

    void Update()
    {
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
