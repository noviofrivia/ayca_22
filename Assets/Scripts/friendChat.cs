using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class friendChat : MonoBehaviour
{
    public GameObject friendPanel;
    void Start()
    {
        friendPanel.SetActive(false);
    }

    public void ChatOpen()
    { 
        friendPanel.SetActive(true); 
    }

}
