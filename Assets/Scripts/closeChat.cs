using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class closeChat : MonoBehaviour
{
    public GameObject chatClose;
    public GameObject chatClose1;
    void Start()
    {
        chatClose.SetActive(false);
        chatClose1.SetActive(false);
    }

    public void ChatOpen()
    { 
        chatClose.SetActive(false); 
        chatClose1.SetActive(false);
    }

}
