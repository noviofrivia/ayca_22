using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class select_image_button : MonoBehaviour
{
    private GameObject game_manager;

    public bool button_clicked = false;

    void Start()
    {
        game_manager = GameObject.Find("game_manager");
    }
  

    

    public void OnSelectImageButtonClick()
    {
        if(gameObject.tag == "True" && gameObject.transform.localScale.x == 1f)
        {
            game_manager.GetComponent<game_manager>().correct_image_selected_count++;
        }

        else if (gameObject.tag == "True" && gameObject.transform.localScale.x != 1f)
        {
            game_manager.GetComponent<game_manager>().correct_image_selected_count--;
        }
        if(gameObject.tag != "True" && gameObject.transform.localScale.x == 1f)
        {
            game_manager.GetComponent<game_manager>().correct_image_selected_count -= 5;
        }
        else if (gameObject.tag != "True" && gameObject.transform.localScale.x != 1f)
        {
            game_manager.GetComponent<game_manager>().correct_image_selected_count += 5;
        }

        
    }

    public void ScaleSelectedImage()
    {
        if (!button_clicked)
        {
            button_clicked = true;
            gameObject.transform.localScale = new Vector3(0.8f, 0.8f, 1.0f);
        }

        else
        {
            button_clicked = false;
            gameObject.transform.localScale = new Vector3(1f, 1f, 1.0f);
        }

        
    }
}
