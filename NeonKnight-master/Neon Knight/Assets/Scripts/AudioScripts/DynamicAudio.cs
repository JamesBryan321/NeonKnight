using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class DynamicAudio : MonoBehaviour
{

    public AudioSource music;

    public void ChangeMusic(AudioClip trackLoop)
    {
        if (music.clip.name == trackLoop.name)
            return;

        music.Stop();
        music.clip = trackLoop;
        music.Play();
    }

}
