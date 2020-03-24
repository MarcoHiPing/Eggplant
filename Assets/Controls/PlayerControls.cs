// GENERATED AUTOMATICALLY FROM 'Assets/Controls/PlayerControls.inputactions'

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
            ""name"": ""Electrician"",
            ""id"": ""9014d661-ef44-4406-b4da-cb42bd13069b"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2d3d1375-30f9-4a18-abd0-f437c45a0b3a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c49aefb3-0e6a-4865-9206-13f019c995ca"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Zap"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e7ad80a6-1fa1-4be4-ba4a-a45b0db70048"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""AbilityActivate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""199fadb5-5707-40f8-b6c1-a9fb67beafb0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TargetSwitch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""56618502-bd88-40b7-952d-a4f530c762ad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""191758df-2ef4-4b64-a24a-7cecc5e931ad"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""b6cbf0d9-2a76-4f32-8f8b-1c119d9920b5"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""7a60fd68-3c69-4cb9-806d-724a5183c254"",
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
                    ""id"": ""08d20d6d-7f50-4838-acf6-8a0f331bac8f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cfd85670-4014-49fc-bcd7-7eee27a35855"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4fd0a7c2-e675-4163-8307-613467585a83"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f9a6034f-24d7-4fa3-94db-77fb1f3d3e70"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8f856915-60e9-41f5-8bc0-ca8d3afbe7f6"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4264ff0d-9faf-4558-92d9-20f075276ffe"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04a08258-5456-4307-8c5c-49a0af521021"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8c262b86-05b0-4abb-98ef-720894c8341a"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2679fdab-f6c8-4ca1-a3d4-c761a065dea8"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Zap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6d38deb-5078-47a6-87c3-795e1ccfefcc"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""Zap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f84963fc-69fc-435e-8753-319995144b10"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Zap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9a5a3d9e-af5c-486a-8ce9-cd8928801728"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""AbilityActivate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b60c843a-549d-42b3-9c7e-86d6d97221e6"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""AbilityActivate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79cc956f-ea21-4ecb-98c8-70f267f1b38f"",
                    ""path"": ""<Keyboard>/u"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""AbilityActivate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f92f2031-01dc-4b02-8f0e-2a20c6610338"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""TargetSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afb07287-009a-466e-8bcb-4ad78774a200"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""TargetSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edaea391-e36f-49b8-b8f4-64442f0997f6"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c881098d-fe3a-4cef-97cd-ac3263fc591f"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a158fc68-e80e-4d96-a260-7b24aa7507c7"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Gauntlet"",
            ""id"": ""b9c950e5-e818-46ae-bc9c-7e64513575c7"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""028b5210-8425-440e-a880-5f47b21e2724"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""0c70d4f4-cc4b-4fbc-b24b-aaf3d6b26b6c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Hook"",
                    ""type"": ""PassThrough"",
                    ""id"": ""26343e64-d138-4abd-a90e-e9a3ae2cfafd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""AbilityActivate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""4c6e9e05-9cc4-45d0-b791-0ed361b6b4b5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""TargetSwitch"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d1e3e0aa-3678-4326-b737-0f3d6cc0abd1"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""b6a2b68a-5001-4de9-a93c-b3736f37df1f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""57aa22d1-8b91-49ff-9fb6-8d79f4a454db"",
                    ""path"": ""<DualShockGamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""eb0b1193-54c6-4749-bf2d-c26b2bd2a333"",
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
                    ""id"": ""e4009bfd-9773-4f6d-abe8-7de9d4ddd3f7"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""505e8bd3-3264-4c9b-94c4-9b6932e4c2e8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6745ec69-6fa3-454b-bd15-33ba8cc28321"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d8488a6f-3a19-4675-bddd-dd45884b74c8"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c72df2a7-5d48-4cbc-ba6e-bdb163ab665a"",
                    ""path"": ""<XInputController>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f7fc2a18-2696-424b-b797-e97cb972e061"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8213795a-26b4-44ce-91eb-cc5610f3d845"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""84154b34-4a3e-4cd4-8979-4e918eebc904"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dcb443ba-7f39-4702-8c7d-37060794ef1c"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Hook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43422345-8275-405d-a8a6-2889b3719401"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""Hook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e707c69e-7925-4c1c-a299-a24f7f7d0a56"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Hook"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""facf9fe1-96ed-4111-b334-18a096c5a993"",
                    ""path"": ""<DualShockGamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""AbilityActivate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8354e52c-e10b-4ba5-b23d-3193665b64b5"",
                    ""path"": ""<XInputController>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""AbilityActivate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4863dee2-80c9-40bc-b57a-d280074bb7a7"",
                    ""path"": ""<DualShockGamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""TargetSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bd99dcc-2fd1-476a-8028-e35ceb50deba"",
                    ""path"": ""<XInputController>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""TargetSwitch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aaa78835-b988-4d22-bbb1-75115fa57e2f"",
                    ""path"": ""<DualShockGamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6915ec9c-aafa-4afc-a2e0-1bc0981b2a24"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""XboxOne"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""51d9bbd9-f071-4488-977c-b8c0e8137387"",
                    ""path"": ""<Keyboard>/e"",
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
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""PS4"",
            ""bindingGroup"": ""PS4"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShock4GampadiOS>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""XboxOne"",
            ""bindingGroup"": ""XboxOne"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Electrician
        m_Electrician = asset.FindActionMap("Electrician", throwIfNotFound: true);
        m_Electrician_Movement = m_Electrician.FindAction("Movement", throwIfNotFound: true);
        m_Electrician_Jump = m_Electrician.FindAction("Jump", throwIfNotFound: true);
        m_Electrician_Zap = m_Electrician.FindAction("Zap", throwIfNotFound: true);
        m_Electrician_AbilityActivate = m_Electrician.FindAction("AbilityActivate", throwIfNotFound: true);
        m_Electrician_TargetSwitch = m_Electrician.FindAction("TargetSwitch", throwIfNotFound: true);
        m_Electrician_Interact = m_Electrician.FindAction("Interact", throwIfNotFound: true);
        // Gauntlet
        m_Gauntlet = asset.FindActionMap("Gauntlet", throwIfNotFound: true);
        m_Gauntlet_Movement = m_Gauntlet.FindAction("Movement", throwIfNotFound: true);
        m_Gauntlet_Jump = m_Gauntlet.FindAction("Jump", throwIfNotFound: true);
        m_Gauntlet_Hook = m_Gauntlet.FindAction("Hook", throwIfNotFound: true);
        m_Gauntlet_AbilityActivate = m_Gauntlet.FindAction("AbilityActivate", throwIfNotFound: true);
        m_Gauntlet_TargetSwitch = m_Gauntlet.FindAction("TargetSwitch", throwIfNotFound: true);
        m_Gauntlet_Interact = m_Gauntlet.FindAction("Interact", throwIfNotFound: true);
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

    // Electrician
    private readonly InputActionMap m_Electrician;
    private IElectricianActions m_ElectricianActionsCallbackInterface;
    private readonly InputAction m_Electrician_Movement;
    private readonly InputAction m_Electrician_Jump;
    private readonly InputAction m_Electrician_Zap;
    private readonly InputAction m_Electrician_AbilityActivate;
    private readonly InputAction m_Electrician_TargetSwitch;
    private readonly InputAction m_Electrician_Interact;
    public struct ElectricianActions
    {
        private @PlayerControls m_Wrapper;
        public ElectricianActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Electrician_Movement;
        public InputAction @Jump => m_Wrapper.m_Electrician_Jump;
        public InputAction @Zap => m_Wrapper.m_Electrician_Zap;
        public InputAction @AbilityActivate => m_Wrapper.m_Electrician_AbilityActivate;
        public InputAction @TargetSwitch => m_Wrapper.m_Electrician_TargetSwitch;
        public InputAction @Interact => m_Wrapper.m_Electrician_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Electrician; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ElectricianActions set) { return set.Get(); }
        public void SetCallbacks(IElectricianActions instance)
        {
            if (m_Wrapper.m_ElectricianActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnJump;
                @Zap.started -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnZap;
                @Zap.performed -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnZap;
                @Zap.canceled -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnZap;
                @AbilityActivate.started -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnAbilityActivate;
                @AbilityActivate.performed -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnAbilityActivate;
                @AbilityActivate.canceled -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnAbilityActivate;
                @TargetSwitch.started -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnTargetSwitch;
                @TargetSwitch.performed -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnTargetSwitch;
                @TargetSwitch.canceled -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnTargetSwitch;
                @Interact.started -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_ElectricianActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_ElectricianActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Zap.started += instance.OnZap;
                @Zap.performed += instance.OnZap;
                @Zap.canceled += instance.OnZap;
                @AbilityActivate.started += instance.OnAbilityActivate;
                @AbilityActivate.performed += instance.OnAbilityActivate;
                @AbilityActivate.canceled += instance.OnAbilityActivate;
                @TargetSwitch.started += instance.OnTargetSwitch;
                @TargetSwitch.performed += instance.OnTargetSwitch;
                @TargetSwitch.canceled += instance.OnTargetSwitch;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public ElectricianActions @Electrician => new ElectricianActions(this);

    // Gauntlet
    private readonly InputActionMap m_Gauntlet;
    private IGauntletActions m_GauntletActionsCallbackInterface;
    private readonly InputAction m_Gauntlet_Movement;
    private readonly InputAction m_Gauntlet_Jump;
    private readonly InputAction m_Gauntlet_Hook;
    private readonly InputAction m_Gauntlet_AbilityActivate;
    private readonly InputAction m_Gauntlet_TargetSwitch;
    private readonly InputAction m_Gauntlet_Interact;
    public struct GauntletActions
    {
        private @PlayerControls m_Wrapper;
        public GauntletActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Gauntlet_Movement;
        public InputAction @Jump => m_Wrapper.m_Gauntlet_Jump;
        public InputAction @Hook => m_Wrapper.m_Gauntlet_Hook;
        public InputAction @AbilityActivate => m_Wrapper.m_Gauntlet_AbilityActivate;
        public InputAction @TargetSwitch => m_Wrapper.m_Gauntlet_TargetSwitch;
        public InputAction @Interact => m_Wrapper.m_Gauntlet_Interact;
        public InputActionMap Get() { return m_Wrapper.m_Gauntlet; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GauntletActions set) { return set.Get(); }
        public void SetCallbacks(IGauntletActions instance)
        {
            if (m_Wrapper.m_GauntletActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_GauntletActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_GauntletActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_GauntletActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_GauntletActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_GauntletActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_GauntletActionsCallbackInterface.OnJump;
                @Hook.started -= m_Wrapper.m_GauntletActionsCallbackInterface.OnHook;
                @Hook.performed -= m_Wrapper.m_GauntletActionsCallbackInterface.OnHook;
                @Hook.canceled -= m_Wrapper.m_GauntletActionsCallbackInterface.OnHook;
                @AbilityActivate.started -= m_Wrapper.m_GauntletActionsCallbackInterface.OnAbilityActivate;
                @AbilityActivate.performed -= m_Wrapper.m_GauntletActionsCallbackInterface.OnAbilityActivate;
                @AbilityActivate.canceled -= m_Wrapper.m_GauntletActionsCallbackInterface.OnAbilityActivate;
                @TargetSwitch.started -= m_Wrapper.m_GauntletActionsCallbackInterface.OnTargetSwitch;
                @TargetSwitch.performed -= m_Wrapper.m_GauntletActionsCallbackInterface.OnTargetSwitch;
                @TargetSwitch.canceled -= m_Wrapper.m_GauntletActionsCallbackInterface.OnTargetSwitch;
                @Interact.started -= m_Wrapper.m_GauntletActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_GauntletActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_GauntletActionsCallbackInterface.OnInteract;
            }
            m_Wrapper.m_GauntletActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Hook.started += instance.OnHook;
                @Hook.performed += instance.OnHook;
                @Hook.canceled += instance.OnHook;
                @AbilityActivate.started += instance.OnAbilityActivate;
                @AbilityActivate.performed += instance.OnAbilityActivate;
                @AbilityActivate.canceled += instance.OnAbilityActivate;
                @TargetSwitch.started += instance.OnTargetSwitch;
                @TargetSwitch.performed += instance.OnTargetSwitch;
                @TargetSwitch.canceled += instance.OnTargetSwitch;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }
        }
    }
    public GauntletActions @Gauntlet => new GauntletActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_PS4SchemeIndex = -1;
    public InputControlScheme PS4Scheme
    {
        get
        {
            if (m_PS4SchemeIndex == -1) m_PS4SchemeIndex = asset.FindControlSchemeIndex("PS4");
            return asset.controlSchemes[m_PS4SchemeIndex];
        }
    }
    private int m_XboxOneSchemeIndex = -1;
    public InputControlScheme XboxOneScheme
    {
        get
        {
            if (m_XboxOneSchemeIndex == -1) m_XboxOneSchemeIndex = asset.FindControlSchemeIndex("XboxOne");
            return asset.controlSchemes[m_XboxOneSchemeIndex];
        }
    }
    public interface IElectricianActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnZap(InputAction.CallbackContext context);
        void OnAbilityActivate(InputAction.CallbackContext context);
        void OnTargetSwitch(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
    public interface IGauntletActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnHook(InputAction.CallbackContext context);
        void OnAbilityActivate(InputAction.CallbackContext context);
        void OnTargetSwitch(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
    }
}
