using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class close_second_notification : MonoBehaviour
{
    [SerializeField] private GameObject second_notification;

    public void DestroySecondNotification()
    {
        Destroy(second_notification);
    }
}
