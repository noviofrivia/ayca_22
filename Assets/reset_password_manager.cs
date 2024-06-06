using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class reset_password_manager : MonoBehaviour
{
    private GameObject game_manager;
    public TMP_InputField password_input_field, password2_input_field;
    [SerializeField] private GameObject reset_password_window;
    [SerializeField] private GameObject fakebook_window;
    [SerializeField] private GameObject incorrect_password_text;

    void Start()
    {
        game_manager = GameObject.Find("game_manager");
    }

    public void ResetPassword_Submit()
    {
        incorrect_password_text.SetActive(true);

        string password_enteredText = password_input_field.text.Trim();
        string password2_enteredText = password2_input_field.text.Trim();

        if(password_enteredText == password2_enteredText)
        {
            game_manager.GetComponent<login_manager>().password_correctText = password_enteredText;
        }

        else
        {
            print("olmadý");
        }
    }

    public void FakebookButton()
    {
        reset_password_window.SetActive(false);
        fakebook_window.SetActive(true);
    }
}
