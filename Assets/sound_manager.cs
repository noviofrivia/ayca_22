using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_manager : MonoBehaviour
{
    private AudioSource startup_sound, error_sound, notification_sound, chatbox_sound;

    void OnEnable()
    {
        startup_sound = GameObject.Find("startup_sound").GetComponent<AudioSource>();
        error_sound = GameObject.Find("error_sound").GetComponent<AudioSource>();
        notification_sound = GameObject.Find("notification_sound").GetComponent<AudioSource>();
        //chatbox_sound = GameObject.Find("chatbox_sound").GetComponent<AudioSource>();
    }

    public void Play_Startup_Sound()
    {
        startup_sound.Play(0);
    }

    public void Play_Error_Sound()
    {
        error_sound.Play(0);
    }

    public void Play_Notification_Sound()
    {
        notification_sound.Play(0);
    }

    public void Play_Click_Sound()
    {
        GameObject.Find("click_sound").GetComponent<AudioSource>().Play(0);
    }

    public void Play_Chatbox_Sound()
    {
        //chatbox_sound.Play(0);
        print("chatbox sound played");
    }
}
