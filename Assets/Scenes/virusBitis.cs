using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class virusBitis : MonoBehaviour
{
    public GameObject notification;
    void Start()
    {
        notification.SetActive(false);
        Invoke("Notification_Instantiator", 30f);
    }

    void Notification_Instantiator()
    {
        notification.SetActive(true);
        
    }
}
