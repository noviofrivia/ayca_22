using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareketdur : MonoBehaviour
{
    public float targetXPosition = 357f;
    public float moveSpeed = 5f; // Adjust the speed as needed

    private Vector3 targetPosition;

    void Start()
    {
        // Calculate the target position with the desired x-coordinate
        targetPosition = new Vector3(targetXPosition, transform.position.y, transform.position.z);
    }

    void Update()
    {
        // Check if the current position is not close to the target position
        if (Vector3.Distance(transform.position, targetPosition) > 0.01f)
        {
            // Calculate the direction to move towards the target position
            Vector3 moveDirection = (targetPosition - transform.position).normalized;

            // Move the GameObject towards the target position
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }
}
