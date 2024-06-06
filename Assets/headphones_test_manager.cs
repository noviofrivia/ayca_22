using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class headphones_test_manager : MonoBehaviour
{
    [SerializeField] private GameObject headphones_test;
    [SerializeField] private GameObject audio_test;

    public void Headphones_Submit()
    {
        headphones_test.SetActive(false);
        audio_test.SetActive(true);
    }
}
