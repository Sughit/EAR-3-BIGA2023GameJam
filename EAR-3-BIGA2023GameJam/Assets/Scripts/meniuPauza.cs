using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meniuPauza : MonoBehaviour
{
    public GameObject meniuPauzaObj;
     bool meniuDeschis;
    void Update()
    {

        if(!meniuDeschis)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                meniuPauzaObj.SetActive(true);
                meniuDeschis=true;
                Time.timeScale=0;
                Cursor.visible = true;
            }
        }
        else if(meniuDeschis)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                meniuPauzaObj.SetActive(false);
                meniuDeschis=false;
                Time.timeScale=1;
                Cursor.visible = false;
            } 
        }
    }

    public void Resume()
    {
        meniuPauzaObj.SetActive(false);
        meniuDeschis=false;
        Time.timeScale=1f;
        Cursor.visible = false;

    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale=1f;
        Cursor.visible = false;
    }

    public void Main_Menu()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene("MeniuPrincipal");
        Cursor.visible = true;
    }
}
