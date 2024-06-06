using UnityEngine;
using TMPro;

public class chatGoster : MonoBehaviour
{
    public GameObject chat1;
    public TMP_InputField inputField;

    private CanvasGroup chat1CanvasGroup;
    private CanvasGroup inputFieldCanvasGroup;

    void Start()
    {
        
        chat1CanvasGroup = chat1.GetComponent<CanvasGroup>();
        inputFieldCanvasGroup = inputField.GetComponent<CanvasGroup>();

        if (chat1CanvasGroup == null)
        {
            chat1CanvasGroup = chat1.AddComponent<CanvasGroup>();
        }
        if (inputFieldCanvasGroup == null)
        {
            inputFieldCanvasGroup = inputField.gameObject.AddComponent<CanvasGroup>();
        }

        SetCanvasGroupVisibility(chat1CanvasGroup, false);
        SetCanvasGroupVisibility(inputFieldCanvasGroup, false);
    }

    public void ChatGoster()
    {
        SetCanvasGroupVisibility(chat1CanvasGroup, true);
        SetCanvasGroupVisibility(inputFieldCanvasGroup, true);
    }

    private void SetCanvasGroupVisibility(CanvasGroup canvasGroup, bool visible)
    {
        if (visible)
        {
            canvasGroup.alpha = 1f;
            canvasGroup.blocksRaycasts = true;
            canvasGroup.interactable = true;
        }
        else
        {
            canvasGroup.alpha = 0f;
            canvasGroup.blocksRaycasts = false;
            canvasGroup.interactable = false;
        }
    }
}
