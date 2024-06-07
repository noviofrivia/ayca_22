using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class button_manager : MonoBehaviour
{
    [SerializeField] private GameObject hemen_ara_window;
    [SerializeField] private GameObject ayca_22_chatbox1;
    [SerializeField] private GameObject ayca_22_notification;
    [SerializeField] private GameObject ayca_22_chatbox2;
    [SerializeField] private GameObject facebook_login_canvas;
    [SerializeField] private GameObject main_menu_canvas;
    [SerializeField] private GameObject notepad_window;
    [SerializeField] private GameObject antivirus_app;
    [SerializeField] private GameObject tara_notification1;
    [SerializeField] private GameObject tara_notification2;
    [SerializeField] private GameObject tara_notification3;
    [SerializeField] private GameObject tara_popup1;
    [SerializeField] private GameObject tara_popup2;
    [SerializeField] private GameObject tara_popup3;


    public void Link_Button()
    {
        hemen_ara_window.SetActive(true);
        ayca_22_chatbox1.SetActive(false);
    }

    public void Hemen_Ara_Button()
    {
        GameObject.Find("click_sound").GetComponent<AudioSource>().Play(0);
        SceneManager.LoadScene("Scene2");
    }

    public void Ayca_22_Notification_Button()
    {
        ayca_22_notification.SetActive(false);
        ayca_22_chatbox1.SetActive(true);
    }

    public void Tara_Popup1_Close_Button()
    {
        tara_popup1.SetActive(false);
        GameObject.Find("virus_window_instantiator").GetComponent<virus_window_instantiator>().first_dialogue_box_closed = true;    
    }

    public void Tara_Popup2_Close_Button()
    {
        tara_popup2.SetActive(false);
    }

    public void Facebook_Close_Button()
    {
        facebook_login_canvas.SetActive(false);
        main_menu_canvas.SetActive(true);
    }

    public void Notepad_Close_Button()
    {
        notepad_window.SetActive(false);
    }

    public void Notepad_Icon_Button()
    {
        notepad_window.SetActive(true);
    }

    public void Facebook_Icon_Button()
    {
        facebook_login_canvas.SetActive(true);
    }

    public void Antivirus_Icon_Button()
    {
        antivirus_app.SetActive(true);
        tara_popup2.SetActive(false);
    }

    public void Tara_Notification1_Button()
    {
        tara_notification1.SetActive(false);
        tara_popup1.SetActive(true);
    }

    public void Tara_Notification2_Button()
    {
        tara_notification2.SetActive(false);
        tara_popup2.SetActive(true);
    }

    public void Tara_Notification3_Button()
    {
        tara_notification3.SetActive(false);
        tara_popup3.SetActive(true);
    }

    public void Scan_Button()
    {
        antivirus_app.SetActive(false);
        Invoke("Open_Tara_Notification3", 1f);
    }

    public void Notepad_Icon_Button_SceneLoader()
    {
        SceneManager.LoadScene("Scene3");
    }

    void Open_Tara_Notification3()
    {
        tara_notification3.SetActive(true);
    }
}
