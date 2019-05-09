using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{

    public float health = 100;

    public GameObject deathEffect;

    [Header("Unity Stuff")]
    public Image healthBar;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage ()
    {
        health = health - 25; ;

        healthBar.fillAmount = health / 100f;

        if( health <= 0)
        {
            Debug.Log("Hit.");
            EnemySpawn.enemiesKilled++;
            Score.score += (EnemySpawn.enemiesPerRound * 2);
            Debug.Log(EnemySpawn.enemiesKilled);
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Bullet")
        {
            TakeDamage();
        }
    }


}
