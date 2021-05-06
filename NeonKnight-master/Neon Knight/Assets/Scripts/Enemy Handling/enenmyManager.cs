using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enenmyManager : MonoBehaviour
{


    public GameObject[] brokenVersions;
    public GameObject[] deathVersions;
    public Transform HealthScript;
    float health;


    // Start is called before the first frame update
    void Start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void broken()
    {
        Debug.Log("hit");
        health = GetComponent<Enemy>().health;
        if(HealthScript.GetComponent<Enemy>().health <= 100)
        {
        Debug.Log("healthbelow150");

            foreach (var gameobject in brokenVersions)
            {
                gameobject.SetActive(false);
                Debug.Log("deactivate objects");

            }
            brokenVersions[1].SetActive(true);
        }
        return;
    }
   

}
