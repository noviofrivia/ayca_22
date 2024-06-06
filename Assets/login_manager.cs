using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class login_manager : MonoBehaviour
{
    [SerializeField] private GameObject robot_test_screen;
    [SerializeField] private GameObject sphere_test;
    [SerializeField] private GameObject pikachu_test;
    [SerializeField] private GameObject half_transparent_black_screen;
    [SerializeField] private TextMeshProUGUI header_image_text;
    [SerializeField] private TextMeshProUGUI mail_text;
    [SerializeField] private TextMeshProUGUI ayca_text;
    [SerializeField] private TextMeshProUGUI ayca_text2;
    [SerializeField] private TextMeshProUGUI password_text;
    [SerializeField] private GameObject wrong_login_text_gameobject;
    [SerializeField] private GameObject reset_password_window;
    [SerializeField] private GameObject fakebook_window;

    public TMP_InputField mail_input_field, password_input_field;
    private string mail_correctText;
    public string password_correctText;

    public float login_info_count = 0;

    private bool set_last_password_one_time = false;

    
    void Start()
    {
        
    }

    void Update()
    {
        mail_text.text = mail_correctText;
        password_text.text = password_correctText;

        switch (login_info_count)
        {
            case 0:
                mail_correctText = "superman69@gmail.com";
                password_correctText = "xKralTR";
                ayca_text.text = "";
                ayca_text2.text = "";
                break;
            case 1:
                mail_correctText = "ruhicenet@gmail.com";
                password_correctText = "ruhicenet123";
                ayca_text.text = "Hey, tell that Tara bitch not to get between us okay? Anyway, here's your new login info.";
                ayca_text2.text = "ps: I'm looking at your moms profile on Fakebook rn.";
                break;
            case 2:
                mail_correctText = "SayMyName@gmail.com";
                password_correctText = "Heisenberg22";
                ayca_text.text = "Did you like the song I've picked just for you?";
                ayca_text2.text = "btw I've changed your login information again";
                break;
            case 3:
                if(!set_last_password_one_time)
                {
                    set_last_password_one_time=true;
                    mail_correctText = "d";
                    password_correctText = "ASIODJFNLOKSdfjnk";
                }
                break;
        }
    }

    public void Click_Login_Button()
    {
        CheckText();
    }

    public void MailButton()
    {
        fakebook_window.SetActive(false);
        reset_password_window.SetActive(true);
    }

    public IEnumerator Login_Succesful_Coroutine()
    {
        switch(login_info_count)
        {
            case 0:
                yield return new WaitForSeconds(1f);
                robot_test_screen.SetActive(true);
                StartCoroutine(GameObject.Find("9random_game_manager").GetComponent<ButtonGenerator>().GenerateButtons());
                header_image_text.text = "traffic lights";
                half_transparent_black_screen.SetActive(true);
                wrong_login_text_gameobject.SetActive(false);
                break;
            case 1: 
                yield return new WaitForSeconds(1f);
                half_transparent_black_screen.SetActive(true);
                sphere_test.SetActive(true);
                wrong_login_text_gameobject.SetActive(false);
                break;
            case 2:
                yield return new WaitForSeconds(1f);
                half_transparent_black_screen.SetActive(true);
                pikachu_test.SetActive(true);
                wrong_login_text_gameobject.SetActive(false);
                break;
        }
        
    }

    void CheckText()
    {
        string mail_enteredText = mail_input_field.text.Trim();
        string password_enteredText = password_input_field.text.Trim();

        if (mail_enteredText.Equals(mail_correctText) && password_enteredText.Equals(password_correctText))
        {
            Debug.Log("Correct! The entered text matches the correct text.");
            wrong_login_text_gameobject.SetActive(false);
            StartCoroutine(Login_Succesful_Coroutine());
        }
        else
        {
            wrong_login_text_gameobject.SetActive(true);
            Debug.Log("Incorrect! The entered text does not match the correct text.");
        }
    }
}
