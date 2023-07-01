//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.6.1
//     from Assets/VectorWarInput.inputactions
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

public partial class @VectorWarInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @VectorWarInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""VectorWarInput"",
    ""maps"": [
        {
            ""name"": ""ShipBattleMap"",
            ""id"": ""d4336cbe-2de2-4240-b252-889702ed3c7f"",
            ""actions"": [
                {
                    ""name"": ""Thrust"",
                    ""type"": ""Button"",
                    ""id"": ""9fbc5e01-014f-4149-97b1-664865d1513e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""41830730-9009-4d0a-aa3d-7e2bdeced4b3"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""CounterClockwise"",
                    ""type"": ""Button"",
                    ""id"": ""f1a476a4-4826-4dcb-b116-1c999f791eaa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Clockwise"",
                    ""type"": ""Button"",
                    ""id"": ""4384e921-ca03-468c-b146-3289fc445644"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""ad4862e6-097f-497c-87a2-474e856c8101"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Bomb"",
                    ""type"": ""Button"",
                    ""id"": ""0bf82351-266a-4096-a65d-496ba3aedc68"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""407c50a0-ca94-4f16-bc20-ac2fa5224a60"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""CounterClockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a62e404c-888c-48ce-9b18-7b672a3b69d1"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Clockwise"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6962aaab-27f3-487b-bb58-bb0d0bf92702"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c19400cb-732d-4859-8051-0ce36872d34b"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Bomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""942e160e-517c-40ba-8d9f-c96f692a5d32"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Thrust"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f29a66b2-d81c-433d-a424-21764012074f"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""GlobalMap"",
            ""id"": ""26f64e57-2f42-4855-9ed6-fa6f7b56239c"",
            ""actions"": [
                {
                    ""name"": ""TogglePerformanceMonitoring"",
                    ""type"": ""Button"",
                    ""id"": ""da83d2f2-006b-4cdc-a061-cef7cd4dae6d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""QuitApplication"",
                    ""type"": ""Button"",
                    ""id"": ""f28aa79c-25a3-49ce-ad81-6dc6f435e269"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b827a9db-a640-40a3-ab9a-f4c94ee60c0a"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""TogglePerformanceMonitoring"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b030a58c-ea2e-4710-a22d-5196b4cacd81"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KBM"",
                    ""action"": ""QuitApplication"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KBM"",
            ""bindingGroup"": ""KBM"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // ShipBattleMap
        m_ShipBattleMap = asset.FindActionMap("ShipBattleMap", throwIfNotFound: true);
        m_ShipBattleMap_Thrust = m_ShipBattleMap.FindAction("Thrust", throwIfNotFound: true);
        m_ShipBattleMap_Brake = m_ShipBattleMap.FindAction("Brake", throwIfNotFound: true);
        m_ShipBattleMap_CounterClockwise = m_ShipBattleMap.FindAction("CounterClockwise", throwIfNotFound: true);
        m_ShipBattleMap_Clockwise = m_ShipBattleMap.FindAction("Clockwise", throwIfNotFound: true);
        m_ShipBattleMap_Fire = m_ShipBattleMap.FindAction("Fire", throwIfNotFound: true);
        m_ShipBattleMap_Bomb = m_ShipBattleMap.FindAction("Bomb", throwIfNotFound: true);
        // GlobalMap
        m_GlobalMap = asset.FindActionMap("GlobalMap", throwIfNotFound: true);
        m_GlobalMap_TogglePerformanceMonitoring = m_GlobalMap.FindAction("TogglePerformanceMonitoring", throwIfNotFound: true);
        m_GlobalMap_QuitApplication = m_GlobalMap.FindAction("QuitApplication", throwIfNotFound: true);
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

    // ShipBattleMap
    private readonly InputActionMap m_ShipBattleMap;
    private List<IShipBattleMapActions> m_ShipBattleMapActionsCallbackInterfaces = new List<IShipBattleMapActions>();
    private readonly InputAction m_ShipBattleMap_Thrust;
    private readonly InputAction m_ShipBattleMap_Brake;
    private readonly InputAction m_ShipBattleMap_CounterClockwise;
    private readonly InputAction m_ShipBattleMap_Clockwise;
    private readonly InputAction m_ShipBattleMap_Fire;
    private readonly InputAction m_ShipBattleMap_Bomb;
    public struct ShipBattleMapActions
    {
        private @VectorWarInput m_Wrapper;
        public ShipBattleMapActions(@VectorWarInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Thrust => m_Wrapper.m_ShipBattleMap_Thrust;
        public InputAction @Brake => m_Wrapper.m_ShipBattleMap_Brake;
        public InputAction @CounterClockwise => m_Wrapper.m_ShipBattleMap_CounterClockwise;
        public InputAction @Clockwise => m_Wrapper.m_ShipBattleMap_Clockwise;
        public InputAction @Fire => m_Wrapper.m_ShipBattleMap_Fire;
        public InputAction @Bomb => m_Wrapper.m_ShipBattleMap_Bomb;
        public InputActionMap Get() { return m_Wrapper.m_ShipBattleMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ShipBattleMapActions set) { return set.Get(); }
        public void AddCallbacks(IShipBattleMapActions instance)
        {
            if (instance == null || m_Wrapper.m_ShipBattleMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ShipBattleMapActionsCallbackInterfaces.Add(instance);
            @Thrust.started += instance.OnThrust;
            @Thrust.performed += instance.OnThrust;
            @Thrust.canceled += instance.OnThrust;
            @Brake.started += instance.OnBrake;
            @Brake.performed += instance.OnBrake;
            @Brake.canceled += instance.OnBrake;
            @CounterClockwise.started += instance.OnCounterClockwise;
            @CounterClockwise.performed += instance.OnCounterClockwise;
            @CounterClockwise.canceled += instance.OnCounterClockwise;
            @Clockwise.started += instance.OnClockwise;
            @Clockwise.performed += instance.OnClockwise;
            @Clockwise.canceled += instance.OnClockwise;
            @Fire.started += instance.OnFire;
            @Fire.performed += instance.OnFire;
            @Fire.canceled += instance.OnFire;
            @Bomb.started += instance.OnBomb;
            @Bomb.performed += instance.OnBomb;
            @Bomb.canceled += instance.OnBomb;
        }

        private void UnregisterCallbacks(IShipBattleMapActions instance)
        {
            @Thrust.started -= instance.OnThrust;
            @Thrust.performed -= instance.OnThrust;
            @Thrust.canceled -= instance.OnThrust;
            @Brake.started -= instance.OnBrake;
            @Brake.performed -= instance.OnBrake;
            @Brake.canceled -= instance.OnBrake;
            @CounterClockwise.started -= instance.OnCounterClockwise;
            @CounterClockwise.performed -= instance.OnCounterClockwise;
            @CounterClockwise.canceled -= instance.OnCounterClockwise;
            @Clockwise.started -= instance.OnClockwise;
            @Clockwise.performed -= instance.OnClockwise;
            @Clockwise.canceled -= instance.OnClockwise;
            @Fire.started -= instance.OnFire;
            @Fire.performed -= instance.OnFire;
            @Fire.canceled -= instance.OnFire;
            @Bomb.started -= instance.OnBomb;
            @Bomb.performed -= instance.OnBomb;
            @Bomb.canceled -= instance.OnBomb;
        }

        public void RemoveCallbacks(IShipBattleMapActions instance)
        {
            if (m_Wrapper.m_ShipBattleMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IShipBattleMapActions instance)
        {
            foreach (var item in m_Wrapper.m_ShipBattleMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ShipBattleMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ShipBattleMapActions @ShipBattleMap => new ShipBattleMapActions(this);

    // GlobalMap
    private readonly InputActionMap m_GlobalMap;
    private List<IGlobalMapActions> m_GlobalMapActionsCallbackInterfaces = new List<IGlobalMapActions>();
    private readonly InputAction m_GlobalMap_TogglePerformanceMonitoring;
    private readonly InputAction m_GlobalMap_QuitApplication;
    public struct GlobalMapActions
    {
        private @VectorWarInput m_Wrapper;
        public GlobalMapActions(@VectorWarInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @TogglePerformanceMonitoring => m_Wrapper.m_GlobalMap_TogglePerformanceMonitoring;
        public InputAction @QuitApplication => m_Wrapper.m_GlobalMap_QuitApplication;
        public InputActionMap Get() { return m_Wrapper.m_GlobalMap; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GlobalMapActions set) { return set.Get(); }
        public void AddCallbacks(IGlobalMapActions instance)
        {
            if (instance == null || m_Wrapper.m_GlobalMapActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GlobalMapActionsCallbackInterfaces.Add(instance);
            @TogglePerformanceMonitoring.started += instance.OnTogglePerformanceMonitoring;
            @TogglePerformanceMonitoring.performed += instance.OnTogglePerformanceMonitoring;
            @TogglePerformanceMonitoring.canceled += instance.OnTogglePerformanceMonitoring;
            @QuitApplication.started += instance.OnQuitApplication;
            @QuitApplication.performed += instance.OnQuitApplication;
            @QuitApplication.canceled += instance.OnQuitApplication;
        }

        private void UnregisterCallbacks(IGlobalMapActions instance)
        {
            @TogglePerformanceMonitoring.started -= instance.OnTogglePerformanceMonitoring;
            @TogglePerformanceMonitoring.performed -= instance.OnTogglePerformanceMonitoring;
            @TogglePerformanceMonitoring.canceled -= instance.OnTogglePerformanceMonitoring;
            @QuitApplication.started -= instance.OnQuitApplication;
            @QuitApplication.performed -= instance.OnQuitApplication;
            @QuitApplication.canceled -= instance.OnQuitApplication;
        }

        public void RemoveCallbacks(IGlobalMapActions instance)
        {
            if (m_Wrapper.m_GlobalMapActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGlobalMapActions instance)
        {
            foreach (var item in m_Wrapper.m_GlobalMapActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GlobalMapActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GlobalMapActions @GlobalMap => new GlobalMapActions(this);
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KBM");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    public interface IShipBattleMapActions
    {
        void OnThrust(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnCounterClockwise(InputAction.CallbackContext context);
        void OnClockwise(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnBomb(InputAction.CallbackContext context);
    }
    public interface IGlobalMapActions
    {
        void OnTogglePerformanceMonitoring(InputAction.CallbackContext context);
        void OnQuitApplication(InputAction.CallbackContext context);
    }
}
