using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    private bool MenuActive = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void menuOpen()
    {
        if (MenuActive == false && endMenu.EndMenuActive == false)
        {
            menu.SetActive(true);
            MenuActive = true;
            Time.timeScale = 0f;
        }
        else if (MenuActive == true)
        {
            menu.SetActive(false);
            Time.timeScale = 1f;
            MenuActive = false;
        }
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }

    public void mainMenu()
    {
        scoreManager.currentRound = 0;
        scoreManager.allScore[0] = 0;
        scoreManager.allScore[1] = 0;
        scoreManager.allScore[2] = 0;
        ButtonVR.ballIngame = false;
        MenuActive = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("begin");
    }
}
