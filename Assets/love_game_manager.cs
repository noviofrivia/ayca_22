using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class love_game_manager : MonoBehaviour
{
    [SerializeField] private GameObject whatislove_with_black_screen;
    [SerializeField] private GameObject half_transparent_black_screen;
    [SerializeField] private GameObject wrong_login_text_gameobject;
    [SerializeField] private GameObject forgot_password;
    [SerializeField] private GameObject ayca_notification2;
    [SerializeField] private GameObject ayca_chatbox2;

    public void OnSecondButtonClick()
    {
        whatislove_with_black_screen.SetActive(false);
        half_transparent_black_screen.SetActive(false);
        GameObject.Find("game_manager").GetComponent<login_manager>().login_info_count = 3;
        wrong_login_text_gameobject.SetActive(true);
        forgot_password.SetActive(true);
        Invoke("OpenAycaNoti2", 1.5f);
    }

    void OpenAycaNoti2()
    {
        ayca_notification2.SetActive(true);
    }

    public void OpenAycaChatbox2()
    {
        ayca_notification2.SetActive(false);
        ayca_chatbox2.SetActive(true);
    }

    public void OpenAycaChatbox2_Close()
    {
        ayca_chatbox2.SetActive(false);
    }
}
