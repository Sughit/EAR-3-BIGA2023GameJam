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
            }
        }
        else if(meniuDeschis)
        {
            if(Input.GetKeyDown(KeyCode.Escape))
            {
                meniuPauzaObj.SetActive(false);
                meniuDeschis=false;
                Time.timeScale=1;
            } 
        }
    }

    public void Resume()
    {
        Time.timeScale=1f;
        meniuPauzaObj.SetActive(false);
        meniuDeschis=false;

    }
    public void Restart()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Main_Menu()
    {
         Time.timeScale=1f;
        SceneManager.LoadScene("MeniuPrincipal");
    }
}
