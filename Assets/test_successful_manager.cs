using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_successful_manager : MonoBehaviour
{
    [SerializeField] private GameObject test_successful_screen;
    [SerializeField] private GameObject half_transparent_black_screen;
    private GameObject game_manager;

    void Start()
    {
        game_manager = GameObject.Find("game_manager");
    }

    public void Verify_Button()
    {
        test_successful_screen.SetActive(false);
        half_transparent_black_screen.SetActive(false);
        game_manager.GetComponent<login_manager>().login_info_count++;
    }
}
