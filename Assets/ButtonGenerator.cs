using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonGenerator : MonoBehaviour
{
    [SerializeField] private GameObject buttonPrefab;
    [SerializeField] private Transform[] buttonSpots;
    [SerializeField] private Sprite[] first_round_imageSprites;
    [SerializeField] private Sprite[] second_round_imageSprites;
    private int numberOfTrueButtons = 3;
    

    

    

    public IEnumerator GenerateButtons()
    {
        yield return null;
        ShuffleArray(buttonSpots);

        for (int i = 0; i < buttonSpots.Length; i++)
        {
            GameObject button = Instantiate(buttonPrefab, buttonSpots[i].position, Quaternion.identity);
            button.transform.SetParent(buttonSpots[i]);

            if (i < numberOfTrueButtons)
            {
                button.tag = "True";

                Image buttonImage = button.GetComponent<Image>();
                if (buttonImage != null)
                {
                    buttonImage.sprite = first_round_imageSprites[i];
                }
            }

            else
            {
                Image buttonImage = button.GetComponent<Image>();
                buttonImage.sprite = first_round_imageSprites[i];
            }
        }
    }

    void ShuffleArray(Transform[] array)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            int randomIndex = Random.Range(0, i + 1);
            Transform temp = array[i];
            array[i] = array[randomIndex];
            array[randomIndex] = temp;
        }
    }
}
