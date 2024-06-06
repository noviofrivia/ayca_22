using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedSoundPlayer : MonoBehaviour
{
    public AudioClip soundToPlay;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("PlayDelayedSound", 2f);
    }

    void PlayDelayedSound()
    {
        audioSource.clip = soundToPlay;
        audioSource.Play();
    }
}
