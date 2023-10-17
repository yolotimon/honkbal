using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;
using UnityEngine.SceneManagement;
using System;

public class endMenu : MonoBehaviour
{
    public GameObject end;
    public static bool EndMenuActive = false;

    public TMP_Text score1end;
    public TMP_Text score2end;
    public TMP_Text score3end;
    public TMP_Text sumEnd;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (scoreManager.currentRound > 2)
        //{
        //    Time.timeScale = 0f;
        //    end.SetActive(true);
        //    MenuActive = true;
        //    score1end.text = "round 1: " + scoreManager.allScore[1] + "M";
        //    score2end.text = "round 2: " + scoreManager.allScore[2] + "M";
        //    score3end.text = "round 3: " + scoreManager.allScore[3] + "M";
        //    float sum = scoreManager.allScore.Sum();
        //    sumEnd.text = "total: " + sum.ToString() + "M";
        //}
    }

    public void activateEndMenu()
    {
        Time.timeScale = 0f;
        end.SetActive(true);
        EndMenuActive = true;
        score1end.text = "round 1: " + scoreManager.allScore[0] + "M";
        score2end.text = "round 2: " + scoreManager.allScore[1] + "M";
        score3end.text = "round 3: " + scoreManager.allScore[2] + "M";
        float sum = scoreManager.allScore.Sum();
        sumEnd.text = "total: " + sum.ToString() + "M";
    }

    public void PlayAgain()
    {
        scoreManager.currentRound = 0;
        scoreManager.allScore[0] = 0;
        scoreManager.allScore[1] = 0;
        scoreManager.allScore[2] = 0;
        EndMenuActive = false;
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
