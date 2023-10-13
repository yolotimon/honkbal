using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoreManager : MonoBehaviour
{
    private int currentRound = 0;

    public static scoreManager instance;

    public float[] allScore = new float[3];
    public TMP_Text[] textArray = new TextMeshPro[3];

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
        if (currentRound > 2)
        {
            Time.timeScale = 0f;
        }
    }

    public void SaveScore()
    {
        if (currentRound < allScore.Length)
        {
            allScore[currentRound] = Mathf.Round(ball.dist);
            textArray[currentRound].text = "Distance to player: " + Mathf.Round(ball.dist);
        }
        currentRound++;
    }
}
