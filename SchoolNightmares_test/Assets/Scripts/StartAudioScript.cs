using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAudioScript : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;

    private void Start()
    {
        // Setup path "continuous" refreshing
        InvokeRepeating("PlayMusicClip", 0f, 138f);
        
    }

    public void PlayMusicClip(){
        MusicSource.clip = MusicClip;
        MusicSource.volume = 1f;
        MusicSource.Play();
    }

}
