using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{

    public GameObject menu;
    // Start is called before the first frame update
    void Start()
    {
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 0)
        {
            menu.SetActive(true);
        }
        if(Time.timeScale == 1)
        {
            menu.SetActive(false);
        }
    }

    public void PauseTime()
    {
        if (Time.timeScale == 1)
            Time.timeScale = 0;
        else
            Time.timeScale = 1; 
    }

    public void Menu()
    {
        SceneManager.LoadScene("Menu1");
    }
}
