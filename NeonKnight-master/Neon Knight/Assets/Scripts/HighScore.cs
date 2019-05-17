using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public static bool gameOver = false;
    public GameObject[] highScore;
    
    void Start()
    {
        highScore[0].SetActive(false);
        highScore[1].SetActive(false);
    }

    
    void Update()
    {
        if (gameOver == true)
        {
            highScore[0].SetActive(true);
            highScore[1].SetActive(true);
        }
    }
}
