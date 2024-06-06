using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class load_second_scene : MonoBehaviour
{
    public void LoadSecondScene()
    {
        GameObject.Find("click_sound").GetComponent<AudioSource>().Play(0);
        SceneManager.LoadScene(1);
    }
}
