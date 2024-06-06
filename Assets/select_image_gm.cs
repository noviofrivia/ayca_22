using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class select_image_gm : MonoBehaviour
{
    [SerializeField] private GameObject robot_screen;
    [SerializeField] private GameObject wrong_text_gameobject;
    [SerializeField] private TextMeshProUGUI header_image_text;
    [SerializeField] private GameObject buses_test_with_black_screen;
    private GameObject game_manager;

    

    

    void Start()
    {
        game_manager = GameObject.Find("game_manager");
    }
    

    public void SubmitRobotTest()
    {
        if(game_manager.GetComponent<game_manager>().correct_image_selected_count == 3)
        {
            print("kazandýn");
            robot_screen.SetActive(false);
            Invoke("BusesOpen", 1.5f);  //doðru cevap verilirse sonraki teste geçilir.
            wrong_text_gameobject.SetActive(false);
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
        }

        else
        {
            DeleteExistingImages();
            StartCoroutine(GameObject.Find("9random_game_manager").GetComponent<ButtonGenerator>().GenerateButtons());
            wrong_text_gameobject.SetActive(true);                                                                       //yanlýþ cevap verilirse, try again yazýsý aktifleþir ve resimler yeniden karýþtýrýlýr.
            game_manager.GetComponent<game_manager>().correct_image_selected_count = 0;
        }
    }

    void BusesOpen()
    {
        buses_test_with_black_screen.SetActive(true);
    }

    void DeleteExistingImages()
    {
        GameObject[] parentObjects = GameObject.FindGameObjectsWithTag("ParentTag");

        foreach (GameObject parent in parentObjects)
        {
            Transform[] childTransforms = parent.GetComponentsInChildren<Transform>();

            foreach (Transform childTransform in childTransforms)
            {
                if (childTransform.gameObject == parent)
                    continue;

                Destroy(childTransform.gameObject);
            }
        }
    }

    
}
