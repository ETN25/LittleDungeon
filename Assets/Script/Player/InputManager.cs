using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//fait par Etienne Squi a du tout refaire 3x avec le nouvel input system

public class InputManager : MonoBehaviour
{
    [SerializeField] Raycast Raycast;
    [SerializeField] Movement movement;
    [SerializeField] MouseLook mouseLook;
    [SerializeField] Animator Sword;

    public Controls controls;
    Controls.GroundMouvementActions groundMouvement;
    // Start is called before the first frame update

    Vector2 horizontalInput;
    Vector2 mouseInput;

    private void Awake()
    {
        controls = new Controls();
        groundMouvement = controls.GroundMouvement;

        groundMouvement.HorizontalMouvement.performed += ctx => horizontalInput = ctx.ReadValue<Vector2>();

        groundMouvement.Jump.performed += _ => movement.OnJumpPressed();
        groundMouvement.Attack.performed += _ =>
        {
            Raycast.Attack();
            Sword.SetTrigger("Attack");
        };

            groundMouvement.MouseX.performed += ctx => mouseInput.x = ctx.ReadValue<float>();
        groundMouvement.MouseY.performed += ctx => mouseInput.y = ctx.ReadValue<float>();
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDestroy()
    {
        controls.Disable();
    }

    private void Update()
    {
        movement.ReceiveInput(horizontalInput);
        mouseLook.ReceiveInput(mouseInput);
    }
}
