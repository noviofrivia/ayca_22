using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class notiDenemeScript : MonoBehaviour
{
    private void Update()
    {
        // Find an instance of mesajCevap in the scene
        mesajCevap mesajCevapInstance = FindObjectOfType<mesajCevap>();

        if (mesajCevapInstance != null)
        {
            // Access playerPoints from mesajCevap
            int points = mesajCevapInstance.playerPoints;

            // Now you can use 'points' as needed
            Debug.Log("Player points: " + points);
        }
        else
        {
            
        }
    }
}
