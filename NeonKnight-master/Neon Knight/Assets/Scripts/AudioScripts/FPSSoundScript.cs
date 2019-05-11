using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSSoundScript : MonoBehaviour
{
    //public GameObject player;
    //public GameObject enemy;
    public List<AudioClip> stage1;
    public List<AudioClip> stage2;
    public List<AudioClip> stage3;
    public List<AudioClip> stage4;

    private bool MusicStage2 = false;
    private bool MusicStage3 = false;
    private bool MusicStage4 = false;

    void Start()
    {
        SoundManager.PlayMusic(gameObject, stage1[0]);
    }

    void Update()
    {
        if (EnemySpawn.enemiesAlive > 0 && EnemySpawn.enemiesAlive < 6 && !MusicStage2)
                 {
                     Debug.Log("Stage 2 Looping.");
                     bool MusicStage2 = true;
                     bool MusicStage3 = false;
                     bool MusicStage4 = false;
                     SoundManager.PlayMusic(gameObject, stage2[0]);
                     new WaitForSeconds(stage2[0].length);
                 }
        
        if (EnemySpawn.enemiesAlive > 5 && EnemySpawn.enemiesAlive < 10 && !MusicStage3)
        {
            Debug.Log("Stage 3 Looping.");            
            bool MusicStage2 = false;
            bool MusicStage3 = true;
            bool MusicStage4 = false;
            SoundManager.PlayMusic(gameObject, stage3[0]);
            new WaitForSeconds(stage3[0].length);
        }
        
        if (EnemySpawn.enemiesAlive > 9 && !MusicStage4)
        {
            Debug.Log("Stage 4 Looping.");            
            bool MusicStage2 = false;
            bool MusicStage3 = false;
            bool MusicStage4 = true;
            SoundManager.PlayMusic(gameObject, stage4[0]);
            new WaitForSeconds(stage4[0].length);
        }
    }
}
