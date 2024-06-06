using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buses_game_manager : MonoBehaviour
{
    private GameObject game_manager;
    [SerializeField] private GameObject wrong_text_gameobject;
    [SerializeField] private GameObject wrong_text_gameobject2;
    [SerializeField] private GameObject wrong_text_gameobject3;
    [SerializeField] private GameObject buses_test_with_black_screen;
    [SerializeField] private GameObject buses_test_2;
    [SerializeField] private GameObject buses_test_3;
    [SerializeField] private GameObject shadow_with_black_screen;


    void Start()
    {
        game_manager = GameObject.Find("game_manager");
    }

    
    

    public void SubmitBusesTest()
    {
        if(game_manager.GetComponent<game_manager>().correct_image_selected_count == 4)
        {
            ReScaleImages();
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
            buses_test_with_black_screen.SetActive(false);
            Invoke("Buses2Open", 1.5f);
            wrong_text_gameobject2.SetActive(true);
        }

        else
        {
            ReScaleImages();
            wrong_text_gameobject.SetActive(true);
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
        }
    }

    void Buses2Open()
    {
        buses_test_2.SetActive(true);
    }

    public void SubmitBusesTest2()
    {
        if (game_manager.GetComponent<game_manager>().correct_image_selected_count == 5)
        {
            ReScaleImages();
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
            buses_test_2.SetActive(false);
            Invoke("Buses3Open", 1.5f);
            wrong_text_gameobject3.SetActive(true);
        }

        else
        {
            ReScaleImages();
            wrong_text_gameobject2.SetActive(true);
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
        }
    }

    void Buses3Open()
    {
        buses_test_3.SetActive(true);
    }


    public void SubmitBusesTest3()
    {
        if (game_manager.GetComponent<game_manager>().correct_image_selected_count == 6)
        {
            ReScaleImages();
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
            buses_test_3.SetActive(false);
            StartCoroutine(Shadow_Appear());
        }

        else
        {
            ReScaleImages();
            wrong_text_gameobject3.SetActive(true);
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
        }
    }

    private IEnumerator Shadow_Appear()
    {
        yield return new WaitForSeconds(1f);
        shadow_with_black_screen.SetActive(true);
    }
   

    void ReScaleImages()
    {
        for (int i = 1; i <= 16; i++)
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
