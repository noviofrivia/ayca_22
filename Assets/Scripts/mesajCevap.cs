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

    private float timer = 5.0f;
    private bool timerActive = false;
    private float activeTimer = 10.0f;
    private bool isCountingActiveTime = false;

    void OnEnable()
    {
        // Start the initial timer
        timerActive = true;

        // Subscribe to the TMP_InputField's onSubmit event
        playerInputField.onSubmit.AddListener(StopTimerOnSubmit);
    }

    void OnDisable()
    {
        // Unsubscribe from the TMP_InputField's onSubmit event to avoid memory leaks
        playerInputField.onSubmit.RemoveListener(StopTimerOnSubmit);
    }

    void Update()
    {
        if (timerActive)
        {
            timer -= Time.deltaTime;

            if (timer <= 0.0f)
            {
                // Timer has finished, activate the other GameObject
                objectToActivateAfterTimer.SetActive(true);

                // Start counting how long the other GameObject is active
                isCountingActiveTime = true;

                // Stop the initial timer
                timerActive = false;
            }
        }

        if (isCountingActiveTime)
        {
            activeTimer -= Time.deltaTime;

            if (activeTimer <= 0.0f)
            {
                // Decrease points if the object stays active for 10 seconds
                playerPoints -= 1;

                // Stop counting the active time
                isCountingActiveTime = false;

                // Restart the timer for the next cycle
                RestartTimer();
            }
        }
    }

    void StopTimerOnSubmit(string input)
    {
        // Deactivate all activated panels
        objectToActivateAfterTimer.SetActive(false);
        playerInputField.gameObject.SetActive(false);
        firstPanelObject.SetActive(false);

        // Restart the timer
        RestartTimer();
    }

    void RestartTimer()
    {
        // Reset timers
        timer = 5.0f;
        activeTimer = 10.0f;

        // Restart the initial timer
        timerActive = true;
        isCountingActiveTime = false;
    }
}
