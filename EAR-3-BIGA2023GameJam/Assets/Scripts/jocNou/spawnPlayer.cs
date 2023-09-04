using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject player1;
    public GameObject player2;
    public GameObject player3;

    void Awake()
    {
        if(caracterSelector.pinguinSelectat == 0)
        {
            player.SetActive(true);
        }
        else if(caracterSelector.pinguinSelectat == 1)
        {
            player1.SetActive(true);
        }
        else if(caracterSelector.pinguinSelectat == 2)
        {
            player2.SetActive(true);
        }
        else if(caracterSelector.pinguinSelectat == 3)
        {
            player3.SetActive(true);
        }
    }
}
