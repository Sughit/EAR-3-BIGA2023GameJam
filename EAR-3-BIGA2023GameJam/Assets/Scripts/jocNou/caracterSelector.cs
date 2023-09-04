using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caracterSelector : MonoBehaviour
{
    //public GameObject pinguin;
    public static int pinguinSelectat = 0;

    public void SelectCaracter()
    {
        pinguinSelectat=0;
    }

    public void SelectCaracterUnu()
    {
        pinguinSelectat=1;
    }

    public void SelectCaracterDoi()
    {
        pinguinSelectat=2;
    }

    public void SelectCaracterTrei()
    {
        pinguinSelectat=3;
    }
}
