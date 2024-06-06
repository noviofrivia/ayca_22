using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class mesajCevap : MonoBehaviour
{
    public GameObject objectToActivateAfterTimer;
    public TMP_InputField playerInputField;
    public GameObject firstPanelObject;
    public int playerPoints = 10;
    //aaa

    private float timer = 10.0f;
    private bool timerActive = false;
    private float activeTimer = 10.0f;
    private bool isCountingActiveTime = false;

    void OnEnable()
    {
        timerActive = true;
        playerInputField.onSubmit.AddListener(StopTimerOnSubmit);
    }

    void OnDisable()
    {
        playerInputField.onSubmit.RemoveListener(StopTimerOnSubmit);
    }

    void Update()
    {
        if (timerActive)
        {
            timer -= Time.deltaTime;

            if (timer <= 0.0f)
            {
                objectToActivateAfterTimer.SetActive(true);
                isCountingActiveTime = true;
                timerActive = false;
            }
        }

        if (isCountingActiveTime)
        {
            activeTimer -= Time.deltaTime;

            if (activeTimer <= 0.0f)
            {
                playerPoints -= 1;
                isCountingActiveTime = false;
                RestartTimer();
            }
        }
    }

    void StopTimerOnSubmit(string input)
    {
        objectToActivateAfterTimer.SetActive(false);
        playerInputField.gameObject.SetActive(false);
        firstPanelObject.SetActive(false);
        RestartTimer();
    }

    void RestartTimer()
    {
        timer = 10.0f;
        activeTimer = 10.0f;
        timerActive = true;
        isCountingActiveTime = false;
    }
}
