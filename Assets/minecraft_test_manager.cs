using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class minecraft_test_manager : MonoBehaviour
{
    [SerializeField] private GameObject minecraft_test;
    [SerializeField] private GameObject headphones_test;

    public void Minecraft_Submit()
    {
        minecraft_test.SetActive(false);
        headphones_test.SetActive(true);
    }
}
