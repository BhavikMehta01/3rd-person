using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlWithTarget : MonoBehaviour
{
    [SerializeField] float _mouseSensitivity = 3.0f;
    [SerializeField] float _distanceFromTarget = 3.0f;
    [SerializeField] Vector2 _rotationXMinMax = new Vector2(-40, 40);
    [SerializeField] float _smoothTime = 0.2f;
    public Transform player;
    private float _mouserotationY;
    private float _mouserotationX;

    private Vector3 _currentRotation;
    private Vector3 _smoothVelocity = Vector3.zero;


    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * _mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * _mouseSensitivity;

        _mouserotationY += mouseX;
        _mouserotationX += mouseY;

        // Apply clamping for x rotation 
        _mouserotationX = Mathf.Clamp(_mouserotationX, _rotationXMinMax.x, _rotationXMinMax.y);

        Vector3 nextRotation = new Vector3(_mouserotationX, _mouserotationY);

        // Apply damping between rotation changes
        _currentRotation = Vector3.SmoothDamp(_currentRotation, nextRotation, ref _smoothVelocity, _smoothTime);
        transform.localEulerAngles = _currentRotation;

        // Substract forward vector of the GameObject to point its forward vector to the target
        transform.position = player.position - transform.forward * _distanceFromTarget;
    }
}
