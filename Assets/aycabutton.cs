using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aycabutton : MonoBehaviour
{
    public GameObject window;
    public GameObject button;

    void Start()
    {
        //window.SetActive(false);
    }

    public void ClickOpen()
    {
        window.SetActive(true);
        button.SetActive(false);
    }
}
