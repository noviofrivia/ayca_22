using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shadow_game_manager : MonoBehaviour
{
    [SerializeField] private GameObject shadow_with_black_screen;
    [SerializeField] private GameObject shadow_with_black_screen2;
    [SerializeField] private GameObject wrong_text_gameobject;
    [SerializeField] private GameObject wrong_text_gameobject2;  //wrong textlerden biri ilk aþama diðeri ikinci aþama için
    [SerializeField] private GameObject test_successful_screen;
    
    private GameObject game_manager;



    void Start()
    {
        game_manager = GameObject.Find("game_manager");
    }

    public void SubmitShadowTest()
    {
        if (game_manager.GetComponent<game_manager>().correct_image_selected_count == 1)
        {
            ReScaleImages();
            shadow_with_black_screen.SetActive(false);
            Invoke("OpenShadow2", 1.5f);
            wrong_text_gameobject2.SetActive(true);
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;         //shadow test ilk aþama kazanýlýr ve kartlarýn devrildiði ikinci aþamaya (shadow test 2) geçilir.
            print("won");
        }

        else
        {
            ReScaleImages();
            wrong_text_gameobject.SetActive(true);
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;     //shadow test ilk aþama kaybedilir
            print("lost");
        }
    }

    void OpenShadow2()
    {
        shadow_with_black_screen2.SetActive(true);
    }

    public void SubmitShadowTest2()
    {
        if (game_manager.GetComponent<game_manager>().correct_image_selected_count == 2)
        {
            ReScaleImages();
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;     //shadow test 2 kazanýlýr
            shadow_with_black_screen2.SetActive(false);
            test_successful_screen.SetActive(true);
        }

        else
        {
            ReScaleImages();
            wrong_text_gameobject2.SetActive(true);
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;     //shadow test 2 kaybedilir
            print("lost");
        }
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
