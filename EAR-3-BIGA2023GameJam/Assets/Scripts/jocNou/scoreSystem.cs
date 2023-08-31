using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreSystem : MonoBehaviour
{
    public Text scoreText;
    public static int score;

    void Update()
    {
        scoreText.text = $"Score: {score}";
    }

    void Score(int amount)
    {
        score += amount;
        scoreText.text = $"Score: {score}";
    }
}
