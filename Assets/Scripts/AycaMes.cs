using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AycaMes : MonoBehaviour
{
    public float speed = 5f; 
    public float moveDuration = 20f; 
    private float timer = 0f;
    private bool isMoving = true;

    void Update()
    {
        if (isMoving)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
            timer += Time.deltaTime;

            if (timer >= moveDuration)
            {
                isMoving = false;
            }
        }
    }
}
