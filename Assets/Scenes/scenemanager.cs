using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour
{
    public GameObject credits;
    public GameObject notepad;
    public string sceneName;


    public void Start()
    {
        credits.SetActive(false);
        notepad.SetActive(false);

    }
    public void changeScene()
    {
        SceneManager.LoadSceneAsync(sceneName);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void CreditClose()
    {
        notepad.SetActive(false);
    }

    public void CreditOpen()
    {
        credits.SetActive(true);
    }
}
