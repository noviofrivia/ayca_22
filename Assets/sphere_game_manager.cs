using UnityEngine;
using UnityEngine.UI;

public class sphere_game_manager : MonoBehaviour
{
    public Image[] images; // Array to hold your images
    public Button nextButton; // Button to go to the next image
    public Button previousButton; // Button to go to the previous image
    [SerializeField] private GameObject minecraft_test;
    [SerializeField] private GameObject sphere_game;

    private int currentIndex = 0;

    void Start()
    {
        // Ensure all images except the first one are disabled at the start
        for (int i = 0; i < images.Length; i++)
        {
            images[i].gameObject.SetActive(i == 0);
        }

        // Add listeners for the buttons
        nextButton.onClick.AddListener(ShowNextImage);
        previousButton.onClick.AddListener(ShowPreviousImage);
    }

    void ShowNextImage()
    {
        images[currentIndex].gameObject.SetActive(false);
        currentIndex = (currentIndex + 1) % images.Length;
        images[currentIndex].gameObject.SetActive(true);
    }

    void ShowPreviousImage()
    {
        images[currentIndex].gameObject.SetActive(false);
        currentIndex = (currentIndex - 1 + images.Length) % images.Length;
        images[currentIndex].gameObject.SetActive(true);
    }

    public void Sphere_Game_Submit()
    {
        if (images[4].gameObject.activeSelf)
        {
            print("won");
            sphere_game.SetActive(false);
            Invoke("OpenMinecraft", 1.5f);
        }
        else
        {
            images[currentIndex].gameObject.SetActive(false);
            images[0].gameObject.SetActive(true);
            currentIndex = 0;
            print("lost");
        }
    }

    void OpenMinecraft()
    {
        minecraft_test.SetActive(true);
    }
}

