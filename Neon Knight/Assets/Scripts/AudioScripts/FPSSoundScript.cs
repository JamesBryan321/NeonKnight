using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSSoundScript : MonoBehaviour
{
    public GameObject player;
    public GameObject enemy;
    public List<AudioClip> stage1;
    public List<AudioClip> stage2;
    public List<AudioClip> stage3;
    public List<AudioClip> stage4;

    //private bool inCalmZone = true;
    //private bool inAlertZone = false;
    //private bool inDangerZone = false;

    void Start()
    {
        SoundManager.PlayMusic(gameObject, stage1[0]);
    }

    void Update()
    {
        /*if (enemiesAlive > 0 && enemiesAlive < 5)
        {
            SoundManager.PlayMusic(gameObject, stage2[0]);
        }*/
    }
}
