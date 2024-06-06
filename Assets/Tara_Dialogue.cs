using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Tara_Dialogue : MonoBehaviour
{
    public TextMeshProUGUI sentenceText; // The UI Text component where sentences will be displayed
    public Button nextButton; // The Button component that will be used to go to the next sentence
    public string[] sentences; // An array to hold your sentences

    private int currentIndex = 0;

    void Start()
    {
        if (sentences.Length > 0)
        {
            sentenceText.text = sentences[currentIndex];
        }

        nextButton.onClick.AddListener(DisplayNextSentence);
    }

    void DisplayNextSentence()
    {
        currentIndex++;

        if (currentIndex < sentences.Length)
        {
            sentenceText.text = sentences[currentIndex];
        }
        else
        {
            currentIndex = 0; // Reset to the first sentence if you want to loop
            sentenceText.text = sentences[currentIndex];
        }
    }
}

