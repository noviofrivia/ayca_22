using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonScript : MonoBehaviour
{
    public GameObject antivirusMesaj;
    public GameObject chatbarKapat;
    public GameObject inputfieldKapat;
    void Start()
    {
        antivirusMesaj.SetActive(false);
    }

    public void AntivirusMesaj()
    {
        antivirusMesaj.SetActive(true);
        chatbarKapat.SetActive(false);
        inputfieldKapat.SetActive(false);
    }
}
