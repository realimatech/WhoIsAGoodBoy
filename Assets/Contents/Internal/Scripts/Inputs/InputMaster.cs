// GENERATED AUTOMATICALLY FROM 'Assets/Contents/Internal/Scripts/Inputs/Default Input.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMaster : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMaster()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Default Input"",
    ""maps"": [
        {
            ""name"": ""Gameplay Controls"",
            ""id"": ""8e5de5f8-1098-4a30-9104-bffa5bb4cb1a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""2905b0c6-e003-46d0-8187-0c03f4f28473"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""TogglePause"",
                    ""type"": ""Button"",
                    ""id"": ""1e122720-bb6a-4aad-a8f8-3be5b787a7ea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""ad41fa2a-dca7-4b16-bbfb-191e29008543"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""4de553b6-171d-4dd2-abb1-705487583c76"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""8186e47e-e010-4373-a528-5c210f6a043c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""1457f44d-2f4e-40c7-bc1d-94f5a3ee7ea5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""144af401-32a4-4878-a809-b5a4ece72836"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0dc25652-7edf-423a-9f11-3c73e5e65004"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""86aacef4-fa14-43a0-8272-23c70804578f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c02300af-62c6-488d-8bfa-5fc0b9a18e2b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TogglePause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c523110-1e31-45cc-9794-d16e27ab9f02"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""TogglePause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d57a6fe-08cf-4833-95df-77c62ef9867a"",
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
                    ""id"": ""eed639c0-f328-4a99-9faf-83c4f6ee50b8"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c08523d-2d2e-4e2c-9a48-f15135edcde9"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gameplay Controls
        m_GameplayControls = asset.FindActionMap("Gameplay Controls", throwIfNotFound: true);
        m_GameplayControls_Movement = m_GameplayControls.FindAction("Movement", throwIfNotFound: true);
        m_GameplayControls_TogglePause = m_GameplayControls.FindAction("TogglePause", throwIfNotFound: true);
        m_GameplayControls_Jump = m_GameplayControls.FindAction("Jump", throwIfNotFound: true);
        m_GameplayControls_Interact = m_GameplayControls.FindAction("Interact", throwIfNotFound: true);
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

    // Gameplay Controls
    private readonly InputActionMap m_GameplayControls;
    private IGameplayControlsActions m_GameplayControlsActionsCallbackInterface;
    private readonly InputAction m_GameplayControls_Movement;
    private readonly InputAction m_GameplayControls_TogglePause;
    private readonly InputAction m_GameplayControls_Jump;
    private readonly InputAction m_GameplayControls_Interact;
    public struct GameplayControlsActions
    {
        private @InputMaster m_Wrapper;
        public GameplayControlsActions(@InputMaster wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_GameplayControls_Movement;
        public InputAction @TogglePause => m_Wrapper.m_GameplayControls_TogglePause;
        public InputAction @Jump => m_Wrapper.m_GameplayControls_Jump;
        public InputAction @Interact => m_Wrapper.m_GameplayControls_Interact;
        public InputActionMap Get() { return m_Wrapper.m_GameplayControls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayControlsActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayControlsActions instance)
        {
            if (m_Wrapper.m_GameplayControlsActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnMovement;
                @TogglePause.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnTogglePause;
                @TogglePause.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnTogglePause;
                @TogglePause.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnTogglePause;
                @Jump.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnJump;
                @Interact.started -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GameplayControlsActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_GameplayControlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @TogglePause.started += instance.OnTogglePause;
                @TogglePause.performed += instance.OnTogglePause;
                @TogglePause.canceled += instance.OnTogglePause;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public GameplayControlsActions @GameplayControls => new GameplayControlsActions(this);
    public interface IGameplayControlsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnTogglePause(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
