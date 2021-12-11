// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Player/InputMap.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputMap : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""PlayerInput"",
            ""id"": ""0357e000-7c23-4299-b5f2-ae9ccf326855"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""e31bbab6-b482-4264-a065-61380c03a679"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Value"",
                    ""id"": ""35f83d75-57a1-4682-a072-329d33f5573e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""23a83441-9412-4c8c-b244-f94ebc65f08b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Hud"",
                    ""type"": ""Button"",
                    ""id"": ""333fe457-acd5-4d15-9421-78be675ddc3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Bomb"",
                    ""type"": ""Button"",
                    ""id"": ""240b7a70-d722-4796-a9d3-4f5f31b2389d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Consumable"",
                    ""type"": ""Button"",
                    ""id"": ""1433ff4b-78ae-424c-a309-7bf01c1176db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""df1e07e8-c30e-4bd7-8119-a77ccbabafc3"",
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
                    ""id"": ""fc1a4d87-de65-4336-a4d6-3ee46ddcc576"",
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
                    ""id"": ""1d38db11-54f7-424a-b2de-eb30be6b51a8"",
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
                    ""id"": ""ae276ec3-ad7c-4536-bfc4-5a784db1f8ed"",
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
                    ""id"": ""d5f45d22-851a-4a2c-ad1d-afde3c4e1679"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller Stick"",
                    ""id"": ""3510941f-1e2a-49a2-9417-d0e138b5b51c"",
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
                    ""id"": ""7475f9ee-0f66-40c2-816b-3cd569a53422"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a92911da-bf48-4f7b-b235-b5f8c16ea0c3"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""367ff878-2e28-4e84-b4de-35e3f56d4d84"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1134d50d-ed32-4037-a551-b7615b79a6d2"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller Arrows"",
                    ""id"": ""14f87a02-93fe-4442-8fec-e7649ad854af"",
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
                    ""id"": ""e01d0705-ac32-4196-846c-f1528e65cf53"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""c840c47e-53c2-43a3-9b1b-6c631905b56b"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ff9c108a-899b-4ccc-982c-40b176e73561"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9ca1527e-04f4-445c-b815-80b637989438"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""e1aa8927-5c2a-44fa-8f31-97f5cd214d22"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""371b593a-6bb8-468e-b864-3074df0a5fd4"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8629ce80-ccbf-4cfb-98ea-d6c65b7b06eb"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b980a3f9-5003-4765-91ef-11f95971e35c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9eb99c34-7b43-4fc7-9fac-3878322c5ded"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller keys"",
                    ""id"": ""bcf72b92-a76f-4c2b-bf04-7ae23f8eac9c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cb9b9cb8-99f4-4bc5-b2b7-f13d24efa544"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9d233e67-ff62-456b-89de-9b9f5e5c49f4"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0a0bbabc-aba8-4c3f-9b08-2eb81070044e"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d4de95f4-f12c-4423-886e-598783a4381a"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Controller Joystick"",
                    ""id"": ""49ecfc93-75ea-46f2-a96e-e04395b62362"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""35ea416b-1562-40bd-8e9f-de8b72559326"",
                    ""path"": ""<XInputController>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6fe30191-7a89-4be7-8601-7bf74828ffc0"",
                    ""path"": ""<XInputController>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7cb384d5-f528-4bd1-8169-c031c73582a5"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""422151f2-5634-4a62-bd99-7201ebe7ebc0"",
                    ""path"": ""<XInputController>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4eabff57-2dc3-481d-ab38-68314c75f064"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""841e4c0f-0fc9-4918-bf32-2a804f443d2c"",
                    ""path"": ""<Keyboard>/p"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8dfd879b-4913-4b35-97fb-f37a7568592e"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c981641b-a12a-4ca5-8ff6-63cd34d09bd3"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hud"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""537bac14-4f83-4f0f-a37a-17eaf7de349d"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Hud"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7c69694e-da24-4970-b8eb-90ce53a63c1d"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Bomb"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04aa2a23-b860-4027-96f8-d72a95655a87"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Consumable"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MenuInput"",
            ""id"": ""72c28aaa-9625-4b8c-bf73-631fdef1b80d"",
            ""actions"": [
                {
                    ""name"": ""Validate"",
                    ""type"": ""Button"",
                    ""id"": ""ce67de72-ea4a-4dc5-9b6d-5a0f54ce0690"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""GoBack"",
                    ""type"": ""Button"",
                    ""id"": ""92134f5e-e28b-49c0-9439-854f37bd6b25"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SpecialKey"",
                    ""type"": ""Button"",
                    ""id"": ""25aa2939-598d-40b2-a4b0-faef0c8fe0af"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Button"",
                    ""id"": ""e6264164-4b99-48bc-aea6-1742565549ee"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""cb4e7806-19ff-441d-af86-909b896841e9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e5b5bc5-176c-4331-85e4-e6f30cc04807"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""78560238-9415-41a7-9b7a-f82f3cdfe509"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Validate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f1e50504-a9a6-4a8d-bd1c-58b7d0b90122"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""af31a975-64a6-499d-8253-51f12faf0cf1"",
                    ""path"": ""<Keyboard>/b"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""GoBack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d933770-cdb1-4f7d-b2ff-fc46786e504c"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fa543635-8e47-49da-bdab-d8cd5ff200a7"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialKey"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""f38e9ea7-c244-4f1d-874d-2da9a8ef0a0f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""6e314007-3180-4684-b90e-b49bad7ff037"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3457f90e-52a7-4f00-9885-a1a40e6c3eef"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""b2947768-10a2-48b0-8cb4-dc9a65d64b18"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cf1e4295-66ae-4331-b8e7-8359d8cdbceb"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""55d7a6d3-e892-4212-af45-7b7359ac1e22"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""dd90297e-d185-4f99-beac-897e67754b2e"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""b41c5473-400f-477e-883d-30ec83538021"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a02965ca-45c7-4b23-bdef-ca7740854c89"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // PlayerInput
        m_PlayerInput = asset.FindActionMap("PlayerInput", throwIfNotFound: true);
        m_PlayerInput_Movement = m_PlayerInput.FindAction("Movement", throwIfNotFound: true);
        m_PlayerInput_Shooting = m_PlayerInput.FindAction("Shooting", throwIfNotFound: true);
        m_PlayerInput_Pause = m_PlayerInput.FindAction("Pause", throwIfNotFound: true);
        m_PlayerInput_Hud = m_PlayerInput.FindAction("Hud", throwIfNotFound: true);
        m_PlayerInput_Bomb = m_PlayerInput.FindAction("Bomb", throwIfNotFound: true);
        m_PlayerInput_Consumable = m_PlayerInput.FindAction("Consumable", throwIfNotFound: true);
        // MenuInput
        m_MenuInput = asset.FindActionMap("MenuInput", throwIfNotFound: true);
        m_MenuInput_Validate = m_MenuInput.FindAction("Validate", throwIfNotFound: true);
        m_MenuInput_GoBack = m_MenuInput.FindAction("GoBack", throwIfNotFound: true);
        m_MenuInput_SpecialKey = m_MenuInput.FindAction("SpecialKey", throwIfNotFound: true);
        m_MenuInput_Navigate = m_MenuInput.FindAction("Navigate", throwIfNotFound: true);
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

    // PlayerInput
    private readonly InputActionMap m_PlayerInput;
    private IPlayerInputActions m_PlayerInputActionsCallbackInterface;
    private readonly InputAction m_PlayerInput_Movement;
    private readonly InputAction m_PlayerInput_Shooting;
    private readonly InputAction m_PlayerInput_Pause;
    private readonly InputAction m_PlayerInput_Hud;
    private readonly InputAction m_PlayerInput_Bomb;
    private readonly InputAction m_PlayerInput_Consumable;
    public struct PlayerInputActions
    {
        private @InputMap m_Wrapper;
        public PlayerInputActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerInput_Movement;
        public InputAction @Shooting => m_Wrapper.m_PlayerInput_Shooting;
        public InputAction @Pause => m_Wrapper.m_PlayerInput_Pause;
        public InputAction @Hud => m_Wrapper.m_PlayerInput_Hud;
        public InputAction @Bomb => m_Wrapper.m_PlayerInput_Bomb;
        public InputAction @Consumable => m_Wrapper.m_PlayerInput_Consumable;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInputActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerInputActions instance)
        {
            if (m_Wrapper.m_PlayerInputActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnMovement;
                @Shooting.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnShooting;
                @Shooting.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnShooting;
                @Shooting.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnShooting;
                @Pause.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnPause;
                @Pause.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnPause;
                @Pause.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnPause;
                @Hud.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnHud;
                @Hud.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnHud;
                @Hud.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnHud;
                @Bomb.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnBomb;
                @Bomb.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnBomb;
                @Bomb.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnBomb;
                @Consumable.started -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnConsumable;
                @Consumable.performed -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnConsumable;
                @Consumable.canceled -= m_Wrapper.m_PlayerInputActionsCallbackInterface.OnConsumable;
            }
            m_Wrapper.m_PlayerInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Shooting.started += instance.OnShooting;
                @Shooting.performed += instance.OnShooting;
                @Shooting.canceled += instance.OnShooting;
                @Pause.started += instance.OnPause;
                @Pause.performed += instance.OnPause;
                @Pause.canceled += instance.OnPause;
                @Hud.started += instance.OnHud;
                @Hud.performed += instance.OnHud;
                @Hud.canceled += instance.OnHud;
                @Bomb.started += instance.OnBomb;
                @Bomb.performed += instance.OnBomb;
                @Bomb.canceled += instance.OnBomb;
                @Consumable.started += instance.OnConsumable;
                @Consumable.performed += instance.OnConsumable;
                @Consumable.canceled += instance.OnConsumable;
            }
        }
    }
    public PlayerInputActions @PlayerInput => new PlayerInputActions(this);

    // MenuInput
    private readonly InputActionMap m_MenuInput;
    private IMenuInputActions m_MenuInputActionsCallbackInterface;
    private readonly InputAction m_MenuInput_Validate;
    private readonly InputAction m_MenuInput_GoBack;
    private readonly InputAction m_MenuInput_SpecialKey;
    private readonly InputAction m_MenuInput_Navigate;
    public struct MenuInputActions
    {
        private @InputMap m_Wrapper;
        public MenuInputActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @Validate => m_Wrapper.m_MenuInput_Validate;
        public InputAction @GoBack => m_Wrapper.m_MenuInput_GoBack;
        public InputAction @SpecialKey => m_Wrapper.m_MenuInput_SpecialKey;
        public InputAction @Navigate => m_Wrapper.m_MenuInput_Navigate;
        public InputActionMap Get() { return m_Wrapper.m_MenuInput; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MenuInputActions set) { return set.Get(); }
        public void SetCallbacks(IMenuInputActions instance)
        {
            if (m_Wrapper.m_MenuInputActionsCallbackInterface != null)
            {
                @Validate.started -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnValidate;
                @Validate.performed -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnValidate;
                @Validate.canceled -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnValidate;
                @GoBack.started -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnGoBack;
                @GoBack.performed -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnGoBack;
                @GoBack.canceled -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnGoBack;
                @SpecialKey.started -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnSpecialKey;
                @SpecialKey.performed -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnSpecialKey;
                @SpecialKey.canceled -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnSpecialKey;
                @Navigate.started -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnNavigate;
                @Navigate.performed -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnNavigate;
                @Navigate.canceled -= m_Wrapper.m_MenuInputActionsCallbackInterface.OnNavigate;
            }
            m_Wrapper.m_MenuInputActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Validate.started += instance.OnValidate;
                @Validate.performed += instance.OnValidate;
                @Validate.canceled += instance.OnValidate;
                @GoBack.started += instance.OnGoBack;
                @GoBack.performed += instance.OnGoBack;
                @GoBack.canceled += instance.OnGoBack;
                @SpecialKey.started += instance.OnSpecialKey;
                @SpecialKey.performed += instance.OnSpecialKey;
                @SpecialKey.canceled += instance.OnSpecialKey;
                @Navigate.started += instance.OnNavigate;
                @Navigate.performed += instance.OnNavigate;
                @Navigate.canceled += instance.OnNavigate;
            }
        }
    }
    public MenuInputActions @MenuInput => new MenuInputActions(this);
    public interface IPlayerInputActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnHud(InputAction.CallbackContext context);
        void OnBomb(InputAction.CallbackContext context);
        void OnConsumable(InputAction.CallbackContext context);
    }
    public interface IMenuInputActions
    {
        void OnValidate(InputAction.CallbackContext context);
        void OnGoBack(InputAction.CallbackContext context);
        void OnSpecialKey(InputAction.CallbackContext context);
        void OnNavigate(InputAction.CallbackContext context);
    }
}
