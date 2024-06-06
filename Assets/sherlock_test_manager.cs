using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sherlock_test_manager : MonoBehaviour
{
    private GameObject game_manager;
    [SerializeField] private GameObject wrong_text_gameobject;
    [SerializeField] private GameObject sherlock_test;
    [SerializeField] private GameObject pigeon_test;

    void Start()
    {
        game_manager = GameObject.Find("game_manager");
    }

    public void Sherlock_Submit()
    {
        if (game_manager.GetComponent<game_manager>().correct_image_selected_count == 1)
        {
            ReScaleImages();
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
            sherlock_test.SetActive(false);
            Invoke("PigeonLevelOpen", 1.5f);
            print("won");
        }

        else
        {
            ReScaleImages();
            wrong_text_gameobject.SetActive(true);
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
            print("lost");
        }
    }

    void PigeonLevelOpen()
    {
        pigeon_test.SetActive(true);
    }

    void ReScaleImages()
    {
        for (int i = 1; i <= 6; i++)
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
}
