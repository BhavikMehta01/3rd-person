using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlWithOutTarget : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public float maxXRotation = 80f;
    public float minXRotation = -80f;

    private bool isDragging = false;

    /// <summary>
    /// Mouse drag
    /// </summary>
    private Vector3 dragOrigin; // Origin of the mouse drag

    void Update()
    {
        // Check for mouse button down to start dragging
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            dragOrigin = Input.mousePosition;
        }

        // Check for mouse button up to stop dragging
        if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        // If dragging, rotate the camera based on mouse movement
        if (isDragging)
        {
            Vector3 currentMousePosition = Input.mousePosition;
            float deltaX = currentMousePosition.x - dragOrigin.x;
            float deltaY = currentMousePosition.y - dragOrigin.y;

            // Calculate rotation angles based on mouse movement
            float rotationX = deltaY * rotationSpeed * 20 * Time.deltaTime;
            float rotationY = deltaX * rotationSpeed * 20 * Time.deltaTime;

            // Apply rotation
            Vector3 currentRotation = transform.eulerAngles;
            currentRotation.x = Mathf.Clamp(currentRotation.x - rotationX, minXRotation, maxXRotation);
            currentRotation.y += rotationY;
            transform.rotation = Quaternion.Euler(currentRotation);

            // Update drag origin for the next frame
            dragOrigin = currentMousePosition;
        }
    }
}
