using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyOnClick : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    void Update()
    {
        scoreText.text = $"Score: {score}";
    }
    void OnMouseDown()
    {
        Debug.Log(score);
        score++;
        Destroy(gameObject);
    }
}
