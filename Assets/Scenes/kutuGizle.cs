using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kutuGizle : MonoBehaviour
{
    public GameObject chatClose;
    public GameObject chatClose1;

    private CanvasGroup chatCloseCanvasGroup;
    private CanvasGroup chatClose1CanvasGroup;

    void Start()
    {
        chatCloseCanvasGroup = chatClose.GetComponent<CanvasGroup>();
        chatClose1CanvasGroup = chatClose1.GetComponent<CanvasGroup>();

        if (chatCloseCanvasGroup == null) chatCloseCanvasGroup = chatClose.AddComponent<CanvasGroup>();
        if (chatClose1CanvasGroup == null) chatClose1CanvasGroup = chatClose1.AddComponent<CanvasGroup>();

        //SetCanvasGroupVisibility(chatCloseCanvasGroup, false);
        //SetCanvasGroupVisibility(chatClose1CanvasGroup, false);
    }

    public void ChatClose()
    {
        SetCanvasGroupVisibility(chatCloseCanvasGroup, false);
        SetCanvasGroupVisibility(chatClose1CanvasGroup, false);
    }

    void SetCanvasGroupVisibility(CanvasGroup canvasGroup, bool visible)
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
