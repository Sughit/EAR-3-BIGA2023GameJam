using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptButoane : MonoBehaviour
{
    public void PlayGame()
    {
        Time.timeScale=1;
        Cursor.visible = false;
        SceneManager.LoadScene("jocNou");
    }

    public void ExitGame() 
    { 
        Application.Quit(); 
    }
}