using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    AudioSource audio;

    private bool didPlay;

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }

    public void Initialized(AudioClip clip)
    {
        audio.clip = clip;
        audio.Play();
    }

    public void Play()
    {
        audio.Play();
        didPlay = true;
    }

    void Update()
    {
        if (didPlay == false) return;
        if (audio.isPlaying == false) Destroy(gameObject);
    }
}
