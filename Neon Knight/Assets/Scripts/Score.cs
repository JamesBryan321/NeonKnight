using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    public static float score;

    [SerializeField] public Text currentScore;
    
    void Start()
    {
        score = 0;
        currentScore.text = "SCORE: " + score.ToString();
    }

    void Update()
    {
        //Debug.Log(score);
    }
}
