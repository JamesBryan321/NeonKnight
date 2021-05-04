// GENERATED AUTOMATICALLY FROM 'Assets/Player/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""PlayerActionMap"",
            ""id"": ""367bb333-a8f1-43c3-ae39-74ff0a57131d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""7c383c0e-8c12-4eee-aa98-9d690af6d9bf"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Rotate"",
                    ""type"": ""Value"",
                    ""id"": ""22f1ab75-a5d8-4471-a61d-ee731542d95b"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""689bbac6-0ea0-49b5-b98b-beaca916198a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""c169eb17-ab4a-4f7d-bf51-15b53075a014"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""78793721-6a7f-4b3e-b836-80aa61e4d80d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a3da3e22-3947-4849-96b9-5804497dccd7"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4592b94e-5d7e-4e9c-9e05-45e7a4cf7b20"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a7f7bf2-a602-4743-b4fa-129e37da7958"",
                    ""path"": ""<Gamepad>/leftStickPress"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""DefaultControlScheme"",
            ""bindingGroup"": ""DefaultControlScheme"",
            ""devices"": []
        }
    ]
}");
        // PlayerActionMap
        m_PlayerActionMap = asset.FindActionMap("PlayerActionMap", throwIfNotFound: true);
        m_PlayerActionMap_Move = m_PlayerActionMap.FindAction("Move", throwIfNotFound: true);
        m_PlayerActionMap_Rotate = m_PlayerActionMap.FindAction("Rotate", throwIfNotFound: true);
        m_PlayerActionMap_Shoot = m_PlayerActionMap.FindAction("Shoot", throwIfNotFound: true);
        m_PlayerActionMap_Sprint = m_PlayerActionMap.FindAction("Sprint", throwIfNotFound: true);
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

    // PlayerActionMap
    private readonly InputActionMap m_PlayerActionMap;
    private IPlayerActionMapActions m_PlayerActionMapActionsCallbackInterface;
    private readonly InputAction m_PlayerActionMap_Move;
    private readonly InputAction m_PlayerActionMap_Rotate;
    private readonly InputAction m_PlayerActionMap_Shoot;
    private readonly InputAction m_PlayerActionMap_Sprint;
    public struct PlayerActionMapActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActionMapActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerActionMap_Move;
        public InputAction @Rotate => m_Wrapper.m_PlayerActionMap_Rotate;
        public InputAction @Shoot => m_Wrapper.m_PlayerActionMap_Shoot;
        public InputAction @Sprint => m_Wrapper.m_PlayerActionMap_Sprint;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActionMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionMapActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionMapActions instance)
        {
            if (m_Wrapper.m_PlayerActionMapActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnMove;
                @Rotate.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnRotate;
                @Shoot.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnShoot;
                @Sprint.started -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionMapActionsCallbackInterface.OnSprint;
            }
            m_Wrapper.m_PlayerActionMapActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
            }
        }
    }
    public PlayerActionMapActions @PlayerActionMap => new PlayerActionMapActions(this);
    private int m_DefaultControlSchemeSchemeIndex = -1;
    public InputControlScheme DefaultControlSchemeScheme
    {
        get
        {
            if (m_DefaultControlSchemeSchemeIndex == -1) m_DefaultControlSchemeSchemeIndex = asset.FindControlSchemeIndex("DefaultControlScheme");
            return asset.controlSchemes[m_DefaultControlSchemeSchemeIndex];
        }
    }
    public interface IPlayerActionMapActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRotate(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
    }
}
