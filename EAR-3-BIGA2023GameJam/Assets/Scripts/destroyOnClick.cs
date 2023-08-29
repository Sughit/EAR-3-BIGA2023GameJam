using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyOnClick : MonoBehaviour
{
    public Text scoreText;
    public static int score;
    static int decreaseTimeToDespawn;

    void Update()
    {
        scoreText.text = $"Score: {score}";
        
    }
    void OnMouseDown()
    {
        if(Time.timeScale == 1)
        {
            Debug.Log(despawnTarget.timeToDespawn);
            score++;
            decreaseTimeToDespawn++;
            MinusTimeToDespawn();
            Destroy(gameObject);
        }
    }

    void MinusTimeToDespawn()
    {
        if(decreaseTimeToDespawn == 5)
        {
            if(despawnTarget.timeToDespawn>=0.3f)
                {   
                    despawnTarget.timeToDespawn -= 0.03f;
                    decreaseTimeToDespawn = 0;
                }
        }
    }
}
