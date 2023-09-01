using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class damageText : MonoBehaviour
{
    public float displayTime;
    public Vector3 offSet = new Vector3(0,2,0);
    public Vector3 randomizeIntensity = new Vector3(0.5f,0,0);

    void Start()
    {
        Destroy(gameObject, displayTime);

        transform.localPosition += offSet;
        transform.localPosition += new Vector3(Random.Range(-randomizeIntensity.x, randomizeIntensity.x),
                                               Random.Range(-randomizeIntensity.y, randomizeIntensity.y),0);
    }
}
