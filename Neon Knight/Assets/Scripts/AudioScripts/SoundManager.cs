using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{

    static public void PlayMusic(GameObject gameObj, AudioClip audioClip)
    {
        gameObj.GetComponent<AudioSource>().PlayOneShot(audioClip);
    }
    
}
