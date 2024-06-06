using UnityEngine;
using UnityEngine.UI;

public class McTest_ImageDrag : MonoBehaviour
{
    public Button spawnButton;
    public Image imagePrefab;
    public GameObject minecraftTest;
    

    private GameObject instantiatedImage;
    private bool isImageFollowing = false;

    void Start()
    {
        spawnButton.onClick.AddListener(SpawnImage);
    }

    void Update()
    {
        if (isImageFollowing && instantiatedImage != null)
        {
            Vector3 mousePosition = Input.mousePosition;
            mousePosition.z = 10.0f; // Distance from the camera
            instantiatedImage.transform.position = Camera.main.ScreenToWorldPoint(mousePosition);
        }
    }

    void SpawnImage()
    {
        if (instantiatedImage == null)
        {
            instantiatedImage = Instantiate(imagePrefab.gameObject, Input.mousePosition, Quaternion.identity);
            instantiatedImage.transform.SetParent(minecraftTest.transform, false);
            isImageFollowing = true;
        }
    }
}

