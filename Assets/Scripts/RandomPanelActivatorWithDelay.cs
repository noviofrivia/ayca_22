using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RandomPanelActivatorWithDelay : MonoBehaviour
{
    public GameObject[] panels;
    private bool tekrarEt;

    void Start()
    {
        tekrarEt = true;
        DeactivateAllPanels();
        StartActivatingPanels();
    }

    void DeactivateAllPanels()
    {
        foreach (GameObject panel in panels)
        {
            panel.SetActive(false);
            Button button = panel.GetComponentInChildren<Button>();
            if (button != null)
            {
                button.onClick.AddListener(() => DeactivatePanel(panel));
            }
        }
    }

    void StartActivatingPanels()
    {
        for (int i = 0; i < 3; i++)
        {
            StartCoroutine(ActivatePanelAfterDelay());
        }
    }

    IEnumerator ActivatePanelAfterDelay()
    {
        while (tekrarEt)
        {
            float randomDelay = Random.Range(5f, 10f); // zaman aralýðý belirle
            yield return new WaitForSeconds(randomDelay);

            GameObject panel = GetRandomInactivePanel();
            if (panel != null)
            {
                panel.SetActive(true);
            }
        }
    }

    GameObject GetRandomInactivePanel()
    {
        List<GameObject> inactivePanels = new List<GameObject>();
        foreach (GameObject panel in panels)
        {
            if (!panel.activeSelf)
            {
                inactivePanels.Add(panel);
            }
        }

        if (inactivePanels.Count > 0)
        {
            int randomIndex = Random.Range(0, inactivePanels.Count);
            return inactivePanels[randomIndex];
        }

        return null;
    }

    void DeactivatePanel(GameObject panel)
    {
        panel.SetActive(false);

        // Restart
        StartCoroutine(ActivatePanelAfterDelay());
    }
}
