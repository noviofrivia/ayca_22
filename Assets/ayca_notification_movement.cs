using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ayca_notification_movement : MonoBehaviour
{
    void Update()
    {
        transform.Translate(-500 * Time.deltaTime, 0, 0);
    }
}
