using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class meniuPauza : MonoBehaviour
{
    public GameObject meniuPauzaObj;
     bool meniuDeschis;
     public GameObject ecranMoarte;

     void Start()
    {
         Cursor.visible = false;
    }

    
    void Update()
    {
        if(ecranMoarte.activeSelf == false)
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
        Time.timeScale=1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Cursor.visible = false;
    }

    public void Main_Menu()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene("MeniuPrincipal");
        Cursor.visible = true;
    }
}
