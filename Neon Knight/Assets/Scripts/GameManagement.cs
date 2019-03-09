using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {
    
    public int round = 1;
    int EnemiesInGame;
    int EnemiesSpawnedInGame = 0;
    float EnemySpawnTimer = 0;
    float EnemiesAlive = 0;
    public static float EnemiesKilled = 0;
    float spawnRate;
    public Transform[] EnemySpawnPoints;
    public GameObject[] Enemy;

    static int playerScore = 0;
    //public GUISkin mySkin;

    public static float finalScore;

    void Start () {
        spawnRate = 800;
	}

    void Update() {
        EnemiesInGame = (3 * round);
        if (EnemiesSpawnedInGame < EnemiesInGame)
        {
            if (EnemySpawnTimer > spawnRate)
            {
                spawnEnemy();
                EnemySpawnTimer = 0;      
            }
            else
            {
                EnemySpawnTimer++;
            }
        }
        if (EnemiesAlive > 15)
        {
            //SceneManager.LoadScene("End");
        }

       EnemiesAlive = EnemiesSpawnedInGame - EnemiesKilled;

    }

    public static void AddPoints(int pointValue)
    {
        playerScore += pointValue;
    }


    void spawnEnemy()
    {
        Vector3 randomSpawnPoint = EnemySpawnPoints[Random.Range(0, EnemySpawnPoints.Length)].position;
        //Instantiate(Zombie, randomSpawnPoint, Quaternion.identity);
        transform.localRotation = Quaternion.identity;
        Instantiate(Enemy[Random.Range(0, Enemy.Length)], randomSpawnPoint, Quaternion.identity);
        EnemiesSpawnedInGame++;
        if(EnemiesSpawnedInGame == EnemiesInGame)
        {
            round++;
            spawnRate -= (round * 20);
            finalScore = playerScore;
        }
    }

    /*void OnGUI()
    {
        GUI.skin = mySkin;
        GUIStyle style = mySkin.customStyles[0];

        GUI.Label(new Rect(50, Screen.height - 100, 150, 50), "S C O R E :  ");
        GUI.Label(new Rect(200, Screen.height - 100, 130, 50), "" + playerScore);

        GUI.Label(new Rect(Screen.width - 320, Screen.height - 100, 170, 50), "Z O M B I E S :  ");
        GUI.Label(new Rect(Screen.width - 150, Screen.height - 100, 100, 50), "" + EnemiesAlive);
    }*/
}
