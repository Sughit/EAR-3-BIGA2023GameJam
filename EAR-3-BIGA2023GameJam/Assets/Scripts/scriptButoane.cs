using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptButoane : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale=1;
        SceneManager.LoadScene("SampleScene");
    }

    public void ExitGame() 
    { 
        Application.Quit(); 
    }
}