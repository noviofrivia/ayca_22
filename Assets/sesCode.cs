using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

public class sesCode : MonoBehaviour
{
    public AudioSource audioClip;
    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.name == "collider")
        {
            audioClip.Play();
            Debug.Log("ses oynadı");
        }
        
    }

}
