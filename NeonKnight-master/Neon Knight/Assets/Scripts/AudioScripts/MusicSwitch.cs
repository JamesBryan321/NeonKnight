using System.Collections;
using System.Collections.Generic;
using Unity.UNetWeaver;
using UnityEngine;

public class MusicSwitch : MonoBehaviour
{

    public AudioClip track1;
    public AudioClip track2;
    public AudioClip track3;

    private DynamicAudio audio;
    void Start()
    {
        audio = FindObjectOfType<DynamicAudio>();
    }

    void FixedUpdate()
    {
        if (EnemySpawn.enemiesAlive > 3 && EnemySpawn.enemiesAlive < 6)
        {
            if (track1 != null)            
                audio.ChangeMusic(track1);
            //Debug.Log("Track1 Playing");
        }
        if (EnemySpawn.enemiesAlive > 6 && EnemySpawn.enemiesAlive < 11)
        {
            if (track2 != null)            
                audio.ChangeMusic(track2);
            //Debug.Log("Track2 Playing");
        }
        if (EnemySpawn.enemiesAlive > 11 && EnemySpawn.enemiesAlive < 16)
        {
            if (track3 != null)            
                audio.ChangeMusic(track3);
            //Debug.Log("Track3 Playing");
        }
        
    }
}
