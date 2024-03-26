//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/input/Pinballinput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @Pinballinput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Pinballinput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Pinballinput"",
    ""maps"": [
        {
            ""name"": ""action"",
            ""id"": ""a634609a-5b24-41a8-9aca-3260f705f1f9"",
            ""actions"": [
                {
                    ""name"": ""launch"",
                    ""type"": ""Button"",
                    ""id"": ""8c4ddb5a-399e-438d-9761-2c731de4c9eb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""flipL"",
                    ""type"": ""Button"",
                    ""id"": ""63e20596-250d-4de2-8f3e-200c9575e277"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""flipR"",
                    ""type"": ""Button"",
                    ""id"": ""21e9bfec-5f22-40c3-84fa-624ef1541a21"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b92a06ba-b10e-4684-bd3a-b6816412f354"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""launch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29861c4a-afa3-45c8-a68e-76f1169a994c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""flipL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""44e268bf-abf9-4bce-955b-f626a90e0ce2"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""flipR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Default"",
            ""id"": ""5f6bef92-d2e1-45b2-aa81-69dd754fdd6f"",
            ""actions"": [
                {
                    ""name"": ""LaunchBall"",
                    ""type"": ""Button"",
                    ""id"": ""f0284aa2-ba2f-40c7-be91-e4f6b229e15d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlipperL"",
                    ""type"": ""Button"",
                    ""id"": ""81b042f7-ee53-438d-bec7-346efae05ab3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlipperR"",
                    ""type"": ""Button"",
                    ""id"": ""a1962aa9-65de-45f1-b817-5d35211476ba"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6f633c69-602f-4efd-abe5-135f91c4856e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaunchBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""437c7ac3-41a9-4bc5-b4b6-548853c469f0"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperL"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""83288d31-10f1-4c30-bcda-70c99e3393f1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperR"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // action
        m_action = asset.FindActionMap("action", throwIfNotFound: true);
        m_action_launch = m_action.FindAction("launch", throwIfNotFound: true);
        m_action_flipL = m_action.FindAction("flipL", throwIfNotFound: true);
        m_action_flipR = m_action.FindAction("flipR", throwIfNotFound: true);
        // Default
        m_Default = asset.FindActionMap("Default", throwIfNotFound: true);
        m_Default_LaunchBall = m_Default.FindAction("LaunchBall", throwIfNotFound: true);
        m_Default_FlipperL = m_Default.FindAction("FlipperL", throwIfNotFound: true);
        m_Default_FlipperR = m_Default.FindAction("FlipperR", throwIfNotFound: true);
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // action
    private readonly InputActionMap m_action;
    private List<IActionActions> m_ActionActionsCallbackInterfaces = new List<IActionActions>();
    private readonly InputAction m_action_launch;
    private readonly InputAction m_action_flipL;
    private readonly InputAction m_action_flipR;
    public struct ActionActions
    {
        private @Pinballinput m_Wrapper;
        public ActionActions(@Pinballinput wrapper) { m_Wrapper = wrapper; }
        public InputAction @launch => m_Wrapper.m_action_launch;
        public InputAction @flipL => m_Wrapper.m_action_flipL;
        public InputAction @flipR => m_Wrapper.m_action_flipR;
        public InputActionMap Get() { return m_Wrapper.m_action; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionActions set) { return set.Get(); }
        public void AddCallbacks(IActionActions instance)
        {
            if (instance == null || m_Wrapper.m_ActionActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ActionActionsCallbackInterfaces.Add(instance);
            @launch.started += instance.OnLaunch;
            @launch.performed += instance.OnLaunch;
            @launch.canceled += instance.OnLaunch;
            @flipL.started += instance.OnFlipL;
            @flipL.performed += instance.OnFlipL;
            @flipL.canceled += instance.OnFlipL;
            @flipR.started += instance.OnFlipR;
            @flipR.performed += instance.OnFlipR;
            @flipR.canceled += instance.OnFlipR;
        }

        private void UnregisterCallbacks(IActionActions instance)
        {
            @launch.started -= instance.OnLaunch;
            @launch.performed -= instance.OnLaunch;
            @launch.canceled -= instance.OnLaunch;
            @flipL.started -= instance.OnFlipL;
            @flipL.performed -= instance.OnFlipL;
            @flipL.canceled -= instance.OnFlipL;
            @flipR.started -= instance.OnFlipR;
            @flipR.performed -= instance.OnFlipR;
            @flipR.canceled -= instance.OnFlipR;
        }

        public void RemoveCallbacks(IActionActions instance)
        {
            if (m_Wrapper.m_ActionActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IActionActions instance)
        {
            foreach (var item in m_Wrapper.m_ActionActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ActionActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ActionActions @action => new ActionActions(this);

    // Default
    private readonly InputActionMap m_Default;
    private List<IDefaultActions> m_DefaultActionsCallbackInterfaces = new List<IDefaultActions>();
    private readonly InputAction m_Default_LaunchBall;
    private readonly InputAction m_Default_FlipperL;
    private readonly InputAction m_Default_FlipperR;
    public struct DefaultActions
    {
        private @Pinballinput m_Wrapper;
        public DefaultActions(@Pinballinput wrapper) { m_Wrapper = wrapper; }
        public InputAction @LaunchBall => m_Wrapper.m_Default_LaunchBall;
        public InputAction @FlipperL => m_Wrapper.m_Default_FlipperL;
        public InputAction @FlipperR => m_Wrapper.m_Default_FlipperR;
        public InputActionMap Get() { return m_Wrapper.m_Default; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DefaultActions set) { return set.Get(); }
        public void AddCallbacks(IDefaultActions instance)
        {
            if (instance == null || m_Wrapper.m_DefaultActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Add(instance);
            @LaunchBall.started += instance.OnLaunchBall;
            @LaunchBall.performed += instance.OnLaunchBall;
            @LaunchBall.canceled += instance.OnLaunchBall;
            @FlipperL.started += instance.OnFlipperL;
            @FlipperL.performed += instance.OnFlipperL;
            @FlipperL.canceled += instance.OnFlipperL;
            @FlipperR.started += instance.OnFlipperR;
            @FlipperR.performed += instance.OnFlipperR;
            @FlipperR.canceled += instance.OnFlipperR;
        }

        private void UnregisterCallbacks(IDefaultActions instance)
        {
            @LaunchBall.started -= instance.OnLaunchBall;
            @LaunchBall.performed -= instance.OnLaunchBall;
            @LaunchBall.canceled -= instance.OnLaunchBall;
            @FlipperL.started -= instance.OnFlipperL;
            @FlipperL.performed -= instance.OnFlipperL;
            @FlipperL.canceled -= instance.OnFlipperL;
            @FlipperR.started -= instance.OnFlipperR;
            @FlipperR.performed -= instance.OnFlipperR;
            @FlipperR.canceled -= instance.OnFlipperR;
        }

        public void RemoveCallbacks(IDefaultActions instance)
        {
            if (m_Wrapper.m_DefaultActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IDefaultActions instance)
        {
            foreach (var item in m_Wrapper.m_DefaultActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_DefaultActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public DefaultActions @Default => new DefaultActions(this);
    public interface IActionActions
    {
        void OnLaunch(InputAction.CallbackContext context);
        void OnFlipL(InputAction.CallbackContext context);
        void OnFlipR(InputAction.CallbackContext context);
    }
    public interface IDefaultActions
    {
        void OnLaunchBall(InputAction.CallbackContext context);
        void OnFlipperL(InputAction.CallbackContext context);
        void OnFlipperR(InputAction.CallbackContext context);
    }
}
