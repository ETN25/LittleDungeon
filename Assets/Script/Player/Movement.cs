using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fait par Etienne solo main Prog

public class Movement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 10f;
    [SerializeField] float gravity = -30f;
    bool isGrounded;
    [SerializeField] float jumpHeight = 3.5f;
    bool jump;

    Vector2 horizontalInput;
    Vector3 verticalVelocity = Vector3.zero;
    [SerializeField] LayerMask groundMask;


    private void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, 0.1f, groundMask);
        if (isGrounded)
        {
            verticalVelocity.y = 0;
        }
        
        Vector3 horizontalVelocity = (transform.right * horizontalInput.x + transform.forward * horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        if (jump)
        {
            if (isGrounded)
            {
                verticalVelocity.y = Mathf.Sqrt(-2f * jumpHeight * gravity);
            }
            jump = false;
        }

        verticalVelocity.y += gravity * Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);
    }

    public void ReceiveInput(Vector2 _horizontalInput)
    {
        horizontalInput = _horizontalInput;
        //print(horizontalInput);

    }

    public void OnJumpPressed()
    {
        jump = true;
    }
}
