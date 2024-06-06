using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class final_scene_manager : MonoBehaviour
{
    public GameObject antivirus_app;

    public void AntivirusIconButton()
    {
        antivirus_app.SetActive(true);
    }
}
