using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Linq;

public class scoreManager : MonoBehaviour
{
    public static int currentRound = 0;

    public GameObject endMenu;

    //public GameObject end;
    //private bool MenuActive = false;

    public static scoreManager instance;

    public static float[] allScore = new float[3];
    public TMP_Text[] textArray = new TextMeshPro[3];

    //public TMP_Text score1end;
    //public TMP_Text score2end;
    //public TMP_Text score3end;
    //public TMP_Text sumEnd;

    private int score = 0;

    //public TMP_Text Rone;
    //public TMP_Text Rtwo;
    //public TMP_Text Rthree;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Rone.text = "round 1: " + landing.dist;
        //if (currentRound > 2)
        //{
        //    Time.timeScale = 0f;
        //    end.SetActive(true);
        //    MenuActive = true;
        //    score1end.text = "round 1: " + allScore[1] + "m";
        //    score2end.text = "round 2: " + allScore[2] + "m";
        //    score3end.text = "round 3: " + allScore[3] + "m";
        //    float sum = allScore.Sum();
        //    sumEnd.text = "total: " + sum.ToString() + "m";
        //}

        if (currentRound > 2)
        {
            endMenu.GetComponent<endMenu>().activateEndMenu();
        }
    }

    public void SaveScore()
    {
        if (currentRound < allScore.Length)
        {
            allScore[currentRound] = Mathf.Round(ball.dist);
            textArray[currentRound].text = Mathf.Round(ball.dist) + "M";
        }
        currentRound++;
    }
}
