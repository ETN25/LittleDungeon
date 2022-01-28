using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fait par Etienne qui a abandonné sur la caméra fluide

public class MouseLook : MonoBehaviour
{
    [SerializeField] float sensitivityX = 8f;
    [SerializeField] float sensitivityY = 0.5f;
    float mouseX, MouseY;

    [SerializeField] Transform playerCamera;
    [SerializeField] float xClamp = 85;
    float xRotation = 0f;
    void Update()
    {
        transform.Rotate(Vector3.up, mouseX * Time.deltaTime);

        xRotation -= MouseY * Time.deltaTime;
        xRotation = Mathf.Clamp(xRotation, -xClamp, xClamp);
        Vector3 targetRotation = transform.eulerAngles;
        targetRotation.x = xRotation;
        playerCamera.eulerAngles = targetRotation;
    }

    public void ReceiveInput (Vector2 mouseInput)
    {
        mouseX = mouseInput.x * sensitivityX;
        MouseY = mouseInput.y * sensitivityY;
    }
}
