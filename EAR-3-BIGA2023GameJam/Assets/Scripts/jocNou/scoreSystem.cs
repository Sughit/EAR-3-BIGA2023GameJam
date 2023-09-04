using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreSystem : MonoBehaviour
{
    public Text scoreText;
    public static int score;
    public Text scorFinal;

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = $"Score: {score}";
        scorFinal.text = score.ToString();
    }

    void Score(int amount)
    {
        score += amount;
        scoreText.text = $"Score: {score}";
    }
}
