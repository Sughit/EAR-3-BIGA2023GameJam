using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class destroyOnClick : MonoBehaviour
{
    public Text scoreText;
    public int score;

    void OnMouseClick()
    {
        score++;
        scoreText.text = $"Score: {score}";
        Destroy(gameObject);
    }
}
