using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class scriptButoane : MonoBehaviour
{
    public GameObject setari;
    public GameObject principal;
    public GameObject tutorial;
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
    public void SettingsOpen()
    {
        setari.SetActive(true);
        principal.SetActive(false);
    }
    public void SettingsClose()
    {
        principal.SetActive(true);
        setari.SetActive(false);
    }
    public void TutorialOpen()
    {
        tutorial.SetActive(true);
        principal.SetActive(false);
    }
    public void TutorialClose()
    {
        principal.SetActive(true);
        tutorial.SetActive(false);
    }
}