using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sunetSplash : MonoBehaviour
{
    GameObject sunet;
    AudioSource audio;
    void Awake()
    {
        sunet=GameObject.Find("sunetSplash");
        audio = sunet.GetComponent<AudioSource>();
        audio.Play();
    }

    
}
