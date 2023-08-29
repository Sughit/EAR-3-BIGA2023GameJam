using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyOnClick : MonoBehaviour
{
    public Text scoreText;
    public static int score;
    // static int decreaseTimeToDespawn;

    void Update()
    {
        scoreText.text = $"Score: {score}";
        
    }
    void OnMouseDown()
    {
        if(Time.timeScale == 1)
        {
            Debug.Log(score);
            score++;
            // decreaseTimeToDespawn++;
            Destroy(gameObject);
            // MinusTimeToDespawn();
        }
    }

    // void MinusTimeToDespawn()
    // {
    //     if(decreaseTimeToDespawn == 5)
    //     {
    //         despawnTarget.timeToDespawn -= 0.001f;
    //         decreaseTimeToDespawn = 0;
    //     }
    // }
}
