using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayca_notification_instantiator : MonoBehaviour
{
    [SerializeField] private GameObject notification;
    [SerializeField] private GameObject sound_manager;

    void Start()
    {
        Invoke("Notification_Instantiator", 5f);
        sound_manager.GetComponent<sound_manager>().Play_Startup_Sound();
    }

    void Notification_Instantiator()
    {
        notification.SetActive(true);
        sound_manager.GetComponent<sound_manager>().Play_Notification_Sound();
    }
}
