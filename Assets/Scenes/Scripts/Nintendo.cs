// GENERATED AUTOMATICALLY FROM 'Assets/Scenes/Nintendo.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Nintendo : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Nintendo()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Nintendo"",
    ""maps"": [
        {
            ""name"": ""Gamepad"",
            ""id"": ""0bbe9466-e080-4805-b45d-884af90c0930"",
            ""actions"": [
                {
                    ""name"": ""Right"",
                    ""type"": ""Button"",
                    ""id"": ""a273e816-3db8-445b-93f6-ce6ae4132c94"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""Button"",
                    ""id"": ""86b927f2-a965-4d7b-b919-e7552adbad8a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Disparo"",
                    ""type"": ""Button"",
                    ""id"": ""33bcacb2-c83e-4f8b-9df0-194756d59fb4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e5a03ed7-8d7f-4526-84ad-f6faf35009f5"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70f82e8c-5284-4314-99d1-0ce84a5bc411"",
                    ""path"": ""<SwitchProControllerHID>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36936b0d-edca-41b3-a33f-4a8e376aef4e"",
                    ""path"": ""<SwitchProControllerHID>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Disparo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Gamepad
        m_Gamepad = asset.FindActionMap("Gamepad", throwIfNotFound: true);
        m_Gamepad_Right = m_Gamepad.FindAction("Right", throwIfNotFound: true);
        m_Gamepad_Left = m_Gamepad.FindAction("Left", throwIfNotFound: true);
        m_Gamepad_Disparo = m_Gamepad.FindAction("Disparo", throwIfNotFound: true);
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

    // Gamepad
    private readonly InputActionMap m_Gamepad;
    private IGamepadActions m_GamepadActionsCallbackInterface;
    private readonly InputAction m_Gamepad_Right;
    private readonly InputAction m_Gamepad_Left;
    private readonly InputAction m_Gamepad_Disparo;
    public struct GamepadActions
    {
        private @Nintendo m_Wrapper;
        public GamepadActions(@Nintendo wrapper) { m_Wrapper = wrapper; }
        public InputAction @Right => m_Wrapper.m_Gamepad_Right;
        public InputAction @Left => m_Wrapper.m_Gamepad_Left;
        public InputAction @Disparo => m_Wrapper.m_Gamepad_Disparo;
        public InputActionMap Get() { return m_Wrapper.m_Gamepad; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GamepadActions set) { return set.Get(); }
        public void SetCallbacks(IGamepadActions instance)
        {
            if (m_Wrapper.m_GamepadActionsCallbackInterface != null)
            {
                @Right.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnRight;
                @Left.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnLeft;
                @Disparo.started -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDisparo;
                @Disparo.performed -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDisparo;
                @Disparo.canceled -= m_Wrapper.m_GamepadActionsCallbackInterface.OnDisparo;
            }
            m_Wrapper.m_GamepadActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Disparo.started += instance.OnDisparo;
                @Disparo.performed += instance.OnDisparo;
                @Disparo.canceled += instance.OnDisparo;
            }
        }
    }
    public GamepadActions @Gamepad => new GamepadActions(this);
    public interface IGamepadActions
    {
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnDisparo(InputAction.CallbackContext context);
    }
}
