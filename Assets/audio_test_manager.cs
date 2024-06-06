using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_test_manager : MonoBehaviour
{
    [SerializeField] private GameObject audio_test;
    [SerializeField] private GameObject test_successful;
    [SerializeField] private GameObject play_button;
    [SerializeField] private GameObject pause_button;
    [SerializeField] private AudioSource aloneagain_audio_source;
    private GameObject game_manager;

    void Start()
    {
        game_manager = GameObject.Find("game_manager");
    }

    public void Audio_Submit()
    {
        if (game_manager.GetComponent<game_manager>().correct_image_selected_count == 1)
        {
            ReScaleImages();
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
            audio_test.SetActive(false);
            test_successful.SetActive(true);
            print("won");
        }

        else
        {
            ReScaleImages();
            //wrong_text_gameobject.SetActive(true);
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
            print("lost");
        }
    }

    void ReScaleImages()
    {
        for (int i = 1; i <= 2; i++)
        {
            // Find each GameObject by name
            GameObject obj = GameObject.Find(i.ToString());

            // If the GameObject is found
            if (obj != null)
            {
                // Get the transform of the GameObject
                Transform objTransform = obj.transform;

                // Scale the GameObject to Vector3(1f, 1f, 1f)
                objTransform.localScale = new Vector3(1f, 1f, 1f);

                obj.GetComponent<select_image_button>().button_clicked = false;
            }
            else
            {
                Debug.LogWarning("GameObject " + i + " not found!");
            }
        }
    }



    public void PlayAudio()
    {
        aloneagain_audio_source.Play(0);
        play_button.SetActive(false);
        pause_button.SetActive(true);
    }

    public void PauseAudio()
    {
        aloneagain_audio_source.Pause();
        play_button.SetActive(true);
        pause_button.SetActive(false);
    }
}
