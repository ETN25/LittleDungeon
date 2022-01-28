// GENERATED AUTOMATICALLY FROM 'Assets/Script/Player/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""GroundMouvement"",
            ""id"": ""655d47eb-9709-4acd-8eab-91db07408b86"",
            ""actions"": [
                {
                    ""name"": ""HorizontalMouvement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""17441519-36c2-4d85-a708-5175b6716b8e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""5cdd554c-b22c-4445-955b-b62cd2fca0ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseX"",
                    ""type"": ""PassThrough"",
                    ""id"": ""f8b54436-21c4-4bcc-b81e-9a61078e8584"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseY"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d53c3929-c793-42fb-b49d-fa43e1f0e2ff"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""fa87d940-0b09-42d4-bf68-f9bd85953b4b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""362775d7-9e6e-4d7a-bed6-ad95896c3575"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMouvement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""362afbd1-0cf9-4e81-a426-8b98d42a20b3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMouvement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d3b1fc44-303f-45b9-b3df-ad7c1466794f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMouvement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""209b04bd-46a3-4d12-8321-69e1d52b3e10"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMouvement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f07dd17c-a031-4ded-8946-5770bcf9f428"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""HorizontalMouvement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1b2255f9-10ca-4dd2-bb38-c143db883216"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7d307dc-6b0c-4217-8a80-e1c6b303b36a"",
                    ""path"": ""<Mouse>/delta/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseX"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""61beb3de-85c4-4dcd-8019-ba45bd2b8ae2"",
                    ""path"": ""<Mouse>/delta/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MouseY"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""45d0cbf0-5d8d-4c36-88ec-ea1c507ad6e2"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // GroundMouvement
        m_GroundMouvement = asset.FindActionMap("GroundMouvement", throwIfNotFound: true);
        m_GroundMouvement_HorizontalMouvement = m_GroundMouvement.FindAction("HorizontalMouvement", throwIfNotFound: true);
        m_GroundMouvement_Jump = m_GroundMouvement.FindAction("Jump", throwIfNotFound: true);
        m_GroundMouvement_MouseX = m_GroundMouvement.FindAction("MouseX", throwIfNotFound: true);
        m_GroundMouvement_MouseY = m_GroundMouvement.FindAction("MouseY", throwIfNotFound: true);
        m_GroundMouvement_Attack = m_GroundMouvement.FindAction("Attack", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // GroundMouvement
    private readonly InputActionMap m_GroundMouvement;
    private IGroundMouvementActions m_GroundMouvementActionsCallbackInterface;
    private readonly InputAction m_GroundMouvement_HorizontalMouvement;
    private readonly InputAction m_GroundMouvement_Jump;
    private readonly InputAction m_GroundMouvement_MouseX;
    private readonly InputAction m_GroundMouvement_MouseY;
    private readonly InputAction m_GroundMouvement_Attack;
    public struct GroundMouvementActions
    {
        private @Controls m_Wrapper;
        public GroundMouvementActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @HorizontalMouvement => m_Wrapper.m_GroundMouvement_HorizontalMouvement;
        public InputAction @Jump => m_Wrapper.m_GroundMouvement_Jump;
        public InputAction @MouseX => m_Wrapper.m_GroundMouvement_MouseX;
        public InputAction @MouseY => m_Wrapper.m_GroundMouvement_MouseY;
        public InputAction @Attack => m_Wrapper.m_GroundMouvement_Attack;
        public InputActionMap Get() { return m_Wrapper.m_GroundMouvement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GroundMouvementActions set) { return set.Get(); }
        public void SetCallbacks(IGroundMouvementActions instance)
        {
            if (m_Wrapper.m_GroundMouvementActionsCallbackInterface != null)
            {
                @HorizontalMouvement.started -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnHorizontalMouvement;
                @HorizontalMouvement.performed -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnHorizontalMouvement;
                @HorizontalMouvement.canceled -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnHorizontalMouvement;
                @Jump.started -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnJump;
                @MouseX.started -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnMouseX;
                @MouseX.performed -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnMouseX;
                @MouseX.canceled -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnMouseX;
                @MouseY.started -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnMouseY;
                @MouseY.performed -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnMouseY;
                @MouseY.canceled -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnMouseY;
                @Attack.started -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnAttack;
                @Attack.performed -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnAttack;
                @Attack.canceled -= m_Wrapper.m_GroundMouvementActionsCallbackInterface.OnAttack;
            }
            m_Wrapper.m_GroundMouvementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @HorizontalMouvement.started += instance.OnHorizontalMouvement;
                @HorizontalMouvement.performed += instance.OnHorizontalMouvement;
                @HorizontalMouvement.canceled += instance.OnHorizontalMouvement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @MouseX.started += instance.OnMouseX;
                @MouseX.performed += instance.OnMouseX;
                @MouseX.canceled += instance.OnMouseX;
                @MouseY.started += instance.OnMouseY;
                @MouseY.performed += instance.OnMouseY;
                @MouseY.canceled += instance.OnMouseY;
                @Attack.started += instance.OnAttack;
                @Attack.performed += instance.OnAttack;
                @Attack.canceled += instance.OnAttack;
            }
        }
    }
    public GroundMouvementActions @GroundMouvement => new GroundMouvementActions(this);
    public interface IGroundMouvementActions
    {
        void OnHorizontalMouvement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnMouseX(InputAction.CallbackContext context);
        void OnMouseY(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
    }
}
