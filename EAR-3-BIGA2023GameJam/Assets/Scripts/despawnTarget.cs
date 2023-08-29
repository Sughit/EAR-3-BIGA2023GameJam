using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class despawnTarget : MonoBehaviour
{
    public float timeToDespawn = 6f;

    void Update()
    {
        // if(destroyOnClick.score % 5 == 0)
        // {
        //     timeToDespawn -= 0.01f;
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
