using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{

    public Transform[] spawnPoints;
    public GameObject[] Enemies;

    public float spawnTime;
    
    void Start()
    {
        StartCoroutine(Timer());
    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(spawnTime);
        SpawnEnemy();
        StartCoroutine(Timer());
    }

    public void SpawnEnemy()
    {
        Vector3 randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
        transform.localRotation = Quaternion.identity;
        Instantiate(Enemies[Random.Range(0, Enemies.Length)], randomSpawnPoint, Quaternion.identity);
        Debug.Log("Spawn.");
    }
}
