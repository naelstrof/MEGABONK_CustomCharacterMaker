// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredStandaloneInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

namespace Rewired.Integration.UnityUI
{
  [AddComponentMenu("Rewired/Rewired Standalone Input Module")]
  [Token(Token = "0x2000270")]
  public sealed class RewiredStandaloneInputModule : RewiredPointerInputModule
  {
    [Token(Token = "0x4001196")]
    private const string DEFAULT_ACTION_MOVE_HORIZONTAL = "UIHorizontal";
    [Token(Token = "0x4001197")]
    private const string DEFAULT_ACTION_MOVE_VERTICAL = "UIVertical";
    [Token(Token = "0x4001198")]
    private const string DEFAULT_ACTION_SUBMIT = "UISubmit";
    [Token(Token = "0x4001199")]
    private const string DEFAULT_ACTION_CANCEL = "UICancel";
    [Tooltip("(Optional) Link the Rewired Input Manager here for easier access to Player ids, etc.")]
    [SerializeField]
    [Token(Token = "0x400119A")]
    [FieldOffset(Offset = "0x80")]
    private InputManager_Base rewiredInputManager;
    [SerializeField]
    [Tooltip("Use all Rewired game Players to control the UI. This does not include the System Player. If enabled, this setting overrides individual Player Ids set in Rewired Player Ids.")]
    [Token(Token = "0x400119B")]
    [FieldOffset(Offset = "0x88")]
    private bool useAllRewiredGamePlayers;
    [SerializeField]
    [Tooltip("Allow the Rewired System Player to control the UI.")]
    [Token(Token = "0x400119C")]
    [FieldOffset(Offset = "0x89")]
    private bool useRewiredSystemPlayer;
    [SerializeField]
    [Tooltip("A list of Player Ids that are allowed to control the UI. If Use All Rewired Game Players = True, this list will be ignored.")]
    [Token(Token = "0x400119D")]
    [FieldOffset(Offset = "0x90")]
    private int[] rewiredPlayerIds;
    [SerializeField]
    [Tooltip("Allow only Players with Player.isPlaying = true to control the UI.")]
    [Token(Token = "0x400119E")]
    [FieldOffset(Offset = "0x98")]
    private bool usePlayingPlayersOnly;
    [SerializeField]
    [Tooltip("Player Mice allowed to interact with the UI. Each Player that owns a Player Mouse must also be allowed to control the UI or the Player Mouse will not function.")]
    [Token(Token = "0x400119F")]
    [FieldOffset(Offset = "0xA0")]
    private List<Rewired.Components.PlayerMouse> playerMice;
    [SerializeField]
    [Tooltip("Makes an axis press always move only one UI selection. Enable if you do not want to allow scrolling through UI elements by holding an axis direction.")]
    [Token(Token = "0x40011A0")]
    [FieldOffset(Offset = "0xA8")]
    private bool moveOneElementPerAxisPress;
    [SerializeField]
    [Tooltip("If enabled, Action Ids will be used to set the Actions. If disabled, string names will be used to set the Actions.")]
    [Token(Token = "0x40011A1")]
    [FieldOffset(Offset = "0xA9")]
    private bool setActionsById;
    [SerializeField]
    [Tooltip("Id of the horizontal Action for movement (if axis events are used).")]
    [Token(Token = "0x40011A2")]
    [FieldOffset(Offset = "0xAC")]
    private int horizontalActionId;
    [SerializeField]
    [Tooltip("Id of the vertical Action for movement (if axis events are used).")]
    [Token(Token = "0x40011A3")]
    [FieldOffset(Offset = "0xB0")]
    private int verticalActionId;
    [SerializeField]
    [Tooltip("Id of the Action used to submit.")]
    [Token(Token = "0x40011A4")]
    [FieldOffset(Offset = "0xB4")]
    private int submitActionId;
    [SerializeField]
    [Tooltip("Id of the Action used to cancel.")]
    [Token(Token = "0x40011A5")]
    [FieldOffset(Offset = "0xB8")]
    private int cancelActionId;
    [SerializeField]
    [Tooltip("Name of the horizontal axis for movement (if axis events are used).")]
    [Token(Token = "0x40011A6")]
    [FieldOffset(Offset = "0xC0")]
    private string m_HorizontalAxis;
    [SerializeField]
    [Tooltip("Name of the vertical axis for movement (if axis events are used).")]
    [Token(Token = "0x40011A7")]
    [FieldOffset(Offset = "0xC8")]
    private string m_VerticalAxis;
    [SerializeField]
    [Tooltip("Name of the action used to submit.")]
    [Token(Token = "0x40011A8")]
    [FieldOffset(Offset = "0xD0")]
    private string m_SubmitButton;
    [SerializeField]
    [Tooltip("Name of the action used to cancel.")]
    [Token(Token = "0x40011A9")]
    [FieldOffset(Offset = "0xD8")]
    private string m_CancelButton;
    [SerializeField]
    [Tooltip("Number of selection changes allowed per second when a movement button/axis is held in a direction.")]
    [Token(Token = "0x40011AA")]
    [FieldOffset(Offset = "0xE0")]
    private float m_InputActionsPerSecond;
    [SerializeField]
    [Tooltip("Delay in seconds before vertical/horizontal movement starts repeating continouously when a movement direction is held.")]
    [Token(Token = "0x40011AB")]
    [FieldOffset(Offset = "0xE4")]
    private float m_RepeatDelay;
    [SerializeField]
    [Tooltip("Allows the mouse to be used to select elements.")]
    [Token(Token = "0x40011AC")]
    [FieldOffset(Offset = "0xE8")]
    private bool m_allowMouseInput;
    [SerializeField]
    [Tooltip("Allows the mouse to be used to select elements if the device also supports touch control.")]
    [Token(Token = "0x40011AD")]
    [FieldOffset(Offset = "0xE9")]
    private bool m_allowMouseInputIfTouchSupported;
    [SerializeField]
    [Tooltip("Allows touch input to be used to select elements.")]
    [Token(Token = "0x40011AE")]
    [FieldOffset(Offset = "0xEA")]
    private bool m_allowTouchInput;
    [SerializeField]
    [Tooltip("Deselects the current selection on mouse/touch click when the pointer is not over a selectable object.")]
    [Token(Token = "0x40011AF")]
    [FieldOffset(Offset = "0xEB")]
    private bool m_deselectIfBackgroundClicked;
    [SerializeField]
    [Tooltip("Deselects the current selection on mouse/touch click before selecting the next object.")]
    [Token(Token = "0x40011B0")]
    [FieldOffset(Offset = "0xEC")]
    private bool m_deselectBeforeSelecting;
    [SerializeField]
    [FormerlySerializedAs("m_AllowActivationOnMobileDevice")]
    [Tooltip("Forces the module to always be active.")]
    [Token(Token = "0x40011B1")]
    [FieldOffset(Offset = "0xED")]
    private bool m_ForceModuleActive;
    [Token(Token = "0x40011B2")]
    [FieldOffset(Offset = "0xF0")]
    [NonSerialized]
    private int[] playerIds;
    [Token(Token = "0x40011B3")]
    [FieldOffset(Offset = "0xF8")]
    private bool recompiling;
    [Token(Token = "0x40011B4")]
    [FieldOffset(Offset = "0xF9")]
    [NonSerialized]
    private bool isTouchSupported;
    [Token(Token = "0x40011B5")]
    [FieldOffset(Offset = "0x100")]
    [NonSerialized]
    private double m_PrevActionTime;
    [Token(Token = "0x40011B6")]
    [FieldOffset(Offset = "0x108")]
    [NonSerialized]
    private Vector2 m_LastMoveVector;
    [Token(Token = "0x40011B7")]
    [FieldOffset(Offset = "0x110")]
    [NonSerialized]
    private int m_ConsecutiveMoveCount;
    [Token(Token = "0x40011B8")]
    [FieldOffset(Offset = "0x114")]
    [NonSerialized]
    private bool m_HasFocus;

    [Token(Token = "0x170002BB")]
    public InputManager_Base RewiredInputManager
    {
      [Token(Token = "0x60011E7"), Address(RVA = "0x37A270", Offset = "0x378E70", Length = "0x8")] get => (InputManager_Base) null;
      [Token(Token = "0x60011E8"), Address(RVA = "0x37A880", Offset = "0x379480", Length = "0x10")] set
      {
      }
    }

    [Token(Token = "0x170002BC")]
    public bool UseAllRewiredGamePlayers
    {
      [Token(Token = "0x60011E9"), Address(RVA = "0x37A320", Offset = "0x378F20", Length = "0x8")] get => false;
      [Token(Token = "0x60011EA"), Address(RVA = "0x37AAB0", Offset = "0x3796B0", Length = "0x19")] set
      {
      }
    }

    [Token(Token = "0x170002BD")]
    public bool UseRewiredSystemPlayer
    {
      [Token(Token = "0x60011EB"), Address(RVA = "0x37A340", Offset = "0x378F40", Length = "0x8")] get => false;
      [Token(Token = "0x60011EC"), Address(RVA = "0x37AAE0", Offset = "0x3796E0", Length = "0x19")] set
      {
      }
    }

    [Token(Token = "0x170002BE")]
    public int[] RewiredPlayerIds
    {
      [Token(Token = "0x60011ED"), Address(RVA = "0x37A280", Offset = "0x378E80", Length = "0x7A")] get => (int[]) null;
      [Token(Token = "0x60011EE"), Address(RVA = "0x37A890", Offset = "0x379490", Length = "0xB4")] set
      {
      }
    }

    [Token(Token = "0x170002BF")]
    public bool UsePlayingPlayersOnly
    {
      [Token(Token = "0x60011EF"), Address(RVA = "0x37A330", Offset = "0x378F30", Length = "0x8")] get => false;
      [Token(Token = "0x60011F0"), Address(RVA = "0x37AAD0", Offset = "0x3796D0", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x170002C0")]
    public List<Rewired.Components.PlayerMouse> PlayerMice
    {
      [Token(Token = "0x60011F1"), Address(RVA = "0x37A200", Offset = "0x378E00", Length = "0x6B")] get => (List<Rewired.Components.PlayerMouse>) null;
      [Token(Token = "0x60011F2"), Address(RVA = "0x37A7D0", Offset = "0x3793D0", Length = "0xAF")] set
      {
      }
    }

    [Token(Token = "0x170002C1")]
    public bool MoveOneElementPerAxisPress
    {
      [Token(Token = "0x60011F3"), Address(RVA = "0x37A1F0", Offset = "0x378DF0", Length = "0x8")] get => false;
      [Token(Token = "0x60011F4"), Address(RVA = "0x37A7C0", Offset = "0x3793C0", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x170002C2")]
    public bool allowMouseInput
    {
      [Token(Token = "0x60011F5"), Address(RVA = "0x37A380", Offset = "0x378F80", Length = "0x8")] get => false;
      [Token(Token = "0x60011F6"), Address(RVA = "0x37AC60", Offset = "0x379860", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x170002C3")]
    public bool allowMouseInputIfTouchSupported
    {
      [Token(Token = "0x60011F7"), Address(RVA = "0x37A370", Offset = "0x378F70", Length = "0x8")] get => false;
      [Token(Token = "0x60011F8"), Address(RVA = "0x37AC50", Offset = "0x379850", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x170002C4")]
    public bool allowTouchInput
    {
      [Token(Token = "0x60011F9"), Address(RVA = "0x37A390", Offset = "0x378F90", Length = "0x8")] get => false;
      [Token(Token = "0x60011FA"), Address(RVA = "0x37AC70", Offset = "0x379870", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x170002C5")]
    public bool deselectIfBackgroundClicked
    {
      [Token(Token = "0x60011FB"), Address(RVA = "0x37A3C0", Offset = "0x378FC0", Length = "0x8")] get => false;
      [Token(Token = "0x60011FC"), Address(RVA = "0x37AD90", Offset = "0x379990", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x170002C6")]
    private bool deselectBeforeSelecting
    {
      [Token(Token = "0x60011FD"), Address(RVA = "0x37A3B0", Offset = "0x378FB0", Length = "0x8")] get => false;
      [Token(Token = "0x60011FE"), Address(RVA = "0x37AD80", Offset = "0x379980", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x170002C7")]
    public bool SetActionsById
    {
      [Token(Token = "0x60011FF"), Address(RVA = "0x37A300", Offset = "0x378F00", Length = "0x8")] get => false;
      [Token(Token = "0x6001200"), Address(RVA = "0x37A950", Offset = "0x379550", Length = "0x16")] set
      {
      }
    }

    [Token(Token = "0x170002C8")]
    public int HorizontalActionId
    {
      [Token(Token = "0x6001201"), Address(RVA = "0x37A1E0", Offset = "0x378DE0", Length = "0x7")] get => 0;
      [Token(Token = "0x6001202"), Address(RVA = "0x37A680", Offset = "0x379280", Length = "0x13B")] set
      {
      }
    }

    [Token(Token = "0x170002C9")]
    public int VerticalActionId
    {
      [Token(Token = "0x6001203"), Address(RVA = "0x37A350", Offset = "0x378F50", Length = "0x7")] get => 0;
      [Token(Token = "0x6001204"), Address(RVA = "0x37AB00", Offset = "0x379700", Length = "0x13B")] set
      {
      }
    }

    [Token(Token = "0x170002CA")]
    public int SubmitActionId
    {
      [Token(Token = "0x6001205"), Address(RVA = "0x37A310", Offset = "0x378F10", Length = "0x7")] get => 0;
      [Token(Token = "0x6001206"), Address(RVA = "0x37A970", Offset = "0x379570", Length = "0x13B")] set
      {
      }
    }

    [Token(Token = "0x170002CB")]
    public int CancelActionId
    {
      [Token(Token = "0x6001207"), Address(RVA = "0x37A1D0", Offset = "0x378DD0", Length = "0x7")] get => 0;
      [Token(Token = "0x6001208"), Address(RVA = "0x37A540", Offset = "0x379140", Length = "0x13B")] set
      {
      }
    }

    [Token(Token = "0x170002CC")]
    protected override bool isMouseSupported
    {
      [Token(Token = "0x6001209"), Address(RVA = "0x37A3F0", Offset = "0x378FF0", Length = "0x11C")] get => false;
    }

    [Token(Token = "0x170002CD")]
    private bool isTouchAllowed
    {
      [Token(Token = "0x600120A"), Address(RVA = "0x37A390", Offset = "0x378F90", Length = "0x8")] get => false;
    }

    [Obsolete("allowActivationOnMobileDevice has been deprecated. Use forceModuleActive instead")]
    [Token(Token = "0x170002CE")]
    public bool allowActivationOnMobileDevice
    {
      [Token(Token = "0x600120B"), Address(RVA = "0x37A360", Offset = "0x378F60", Length = "0x8")] get => false;
      [Token(Token = "0x600120C"), Address(RVA = "0x37AC40", Offset = "0x379840", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x170002CF")]
    public bool forceModuleActive
    {
      [Token(Token = "0x600120D"), Address(RVA = "0x37A360", Offset = "0x378F60", Length = "0x8")] get => false;
      [Token(Token = "0x600120E"), Address(RVA = "0x37AC40", Offset = "0x379840", Length = "0x7")] set
      {
      }
    }

    [Token(Token = "0x170002D0")]
    public float inputActionsPerSecond
    {
      [Token(Token = "0x600120F"), Address(RVA = "0x37A3E0", Offset = "0x378FE0", Length = "0x9")] get => 0.0f;
      [Token(Token = "0x6001210"), Address(RVA = "0x37AEA0", Offset = "0x379AA0", Length = "0x9")] set
      {
      }
    }

    [Token(Token = "0x170002D1")]
    public float repeatDelay
    {
      [Token(Token = "0x6001211"), Address(RVA = "0x37A510", Offset = "0x379110", Length = "0x9")] get => 0.0f;
      [Token(Token = "0x6001212"), Address(RVA = "0x37AEB0", Offset = "0x379AB0", Length = "0x9")] set
      {
      }
    }

    [Token(Token = "0x170002D2")]
    public string horizontalAxis
    {
      [Token(Token = "0x6001213"), Address(RVA = "0x37A3D0", Offset = "0x378FD0", Length = "0x8")] get => (string) null;
      [Token(Token = "0x6001214"), Address(RVA = "0x37ADA0", Offset = "0x3799A0", Length = "0xFB")] set
      {
      }
    }

    [Token(Token = "0x170002D3")]
    public string verticalAxis
    {
      [Token(Token = "0x6001215"), Address(RVA = "0x37A530", Offset = "0x379130", Length = "0x8")] get => (string) null;
      [Token(Token = "0x6001216"), Address(RVA = "0x37AFC0", Offset = "0x379BC0", Length = "0xFB")] set
      {
      }
    }

    [Token(Token = "0x170002D4")]
    public string submitButton
    {
      [Token(Token = "0x6001217"), Address(RVA = "0x37A520", Offset = "0x379120", Length = "0x8")] get => (string) null;
      [Token(Token = "0x6001218"), Address(RVA = "0x37AEC0", Offset = "0x379AC0", Length = "0xFB")] set
      {
      }
    }

    [Token(Token = "0x170002D5")]
    public string cancelButton
    {
      [Token(Token = "0x6001219"), Address(RVA = "0x37A3A0", Offset = "0x378FA0", Length = "0x8")] get => (string) null;
      [Token(Token = "0x600121A"), Address(RVA = "0x37AC80", Offset = "0x379880", Length = "0xFB")] set
      {
      }
    }

    [Token(Token = "0x600121B")]
    [Address(RVA = "0x379F00", Offset = "0x378B00", Length = "0x2CD")]
    private RewiredStandaloneInputModule()
    {
    }

    [Token(Token = "0x600121C")]
    [Address(RVA = "0x374C30", Offset = "0x373830", Length = "0xDD")]
    protected override void Awake()
    {
    }

    [Token(Token = "0x600121D")]
    [Address(RVA = "0x379DC0", Offset = "0x3789C0", Length = "0x136")]
    public override void UpdateModule()
    {
    }

    [Token(Token = "0x600121E")]
    [Address(RVA = "0x375D80", Offset = "0x374980", Length = "0x3")]
    public override bool IsModuleSupported() => false;

    [Token(Token = "0x600121F")]
    [Address(RVA = "0x379490", Offset = "0x378090", Length = "0x868")]
    public override bool ShouldActivateModule() => false;

    [Token(Token = "0x6001220")]
    [Address(RVA = "0x374B50", Offset = "0x373750", Length = "0xD9")]
    public override void ActivateModule()
    {
    }

    [Token(Token = "0x6001221")]
    [Address(RVA = "0x374FE0", Offset = "0x373BE0", Length = "0x1F")]
    public override void DeactivateModule()
    {
    }

    [Token(Token = "0x6001222")]
    [Address(RVA = "0x377E10", Offset = "0x376A10", Length = "0x3B7")]
    public override void Process()
    {
    }

    [Token(Token = "0x6001223")]
    [Address(RVA = "0x376AD0", Offset = "0x3756D0", Length = "0xB7D")]
    private bool ProcessTouchEvents() => false;

    [Token(Token = "0x6001224")]
    [Address(RVA = "0x377650", Offset = "0x376250", Length = "0x7B3")]
    private void ProcessTouchPress(PointerEventData pointerEvent, bool pressed, bool released)
    {
    }

    [Token(Token = "0x6001225")]
    [Address(RVA = "0x378570", Offset = "0x377170", Length = "0x25A")]
    private bool SendSubmitEventToSelectedObject() => false;

    [Token(Token = "0x6001226")]
    [Address(RVA = "0x375450", Offset = "0x374050", Length = "0x37A")]
    private Vector2 GetRawMoveVector() => new Vector2();

    [Token(Token = "0x6001227")]
    [Address(RVA = "0x3781D0", Offset = "0x376DD0", Length = "0x398")]
    private bool SendMoveEventToSelectedObject() => false;

    [Token(Token = "0x6001228")]
    [Address(RVA = "0x374D10", Offset = "0x373910", Length = "0x199")]
    private void CheckButtonOrKeyMovement(out bool downHorizontal, out bool downVertical)
    {
      downHorizontal = new bool();
      downVertical = new bool();
    }

    [Token(Token = "0x6001229")]
    [Address(RVA = "0x3762C0", Offset = "0x374EC0", Length = "0x166")]
    private void ProcessMouseEvents()
    {
    }

    [Token(Token = "0x600122A")]
    [Address(RVA = "0x375EE0", Offset = "0x374AE0", Length = "0x3DA")]
    private void ProcessMouseEvent(int playerId, int pointerIndex)
    {
    }

    [Token(Token = "0x600122B")]
    [Address(RVA = "0x3787D0", Offset = "0x3773D0", Length = "0x149")]
    private bool SendUpdateEventToSelectedObject() => false;

    [Token(Token = "0x600122C")]
    [Address(RVA = "0x376430", Offset = "0x375030", Length = "0x697")]
    private void ProcessMousePress(
      RewiredPointerInputModule.MouseButtonEventData data)
    {
    }

    [Token(Token = "0x600122D")]
    [Address(RVA = "0x3757D0", Offset = "0x3743D0", Length = "0x218")]
    private void HandleMouseTouchDeselectionOnSelectionChanged(
      GameObject currentOverGo,
      BaseEventData pointerEvent)
    {
    }

    [Token(Token = "0x600122E")]
    [Address(RVA = "0x375D90", Offset = "0x374990", Length = "0x7")]
    private void OnApplicationFocus(bool hasFocus)
    {
    }

    [Token(Token = "0x600122F")]
    [Address(RVA = "0x379D00", Offset = "0x378900", Length = "0xB5")]
    private bool ShouldIgnoreEventsOnNoFocus() => false;

    [Token(Token = "0x6001230")]
    [Address(RVA = "0x375DA0", Offset = "0x3749A0", Length = "0x10C")]
    protected override void OnDestroy()
    {
    }

    [Token(Token = "0x6001231")]
    [Address(RVA = "0x375BC0", Offset = "0x3747C0", Length = "0x1BE")]
    protected override bool IsDefaultPlayer(int playerId) => false;

    [Token(Token = "0x6001232")]
    [Address(RVA = "0x3759F0", Offset = "0x3745F0", Length = "0x1CD")]
    private void InitializeRewired()
    {
    }

    [Token(Token = "0x6001233")]
    [Address(RVA = "0x378E20", Offset = "0x377A20", Length = "0x66D")]
    private void SetupRewiredVars()
    {
    }

    [Token(Token = "0x6001234")]
    [Address(RVA = "0x378C80", Offset = "0x377880", Length = "0x192")]
    private void SetUpRewiredPlayerMice()
    {
    }

    [Token(Token = "0x6001235")]
    [Address(RVA = "0x378920", Offset = "0x377520", Length = "0x354")]
    private void SetUpRewiredActions()
    {
    }

    [Token(Token = "0x6001236")]
    [Address(RVA = "0x375220", Offset = "0x373E20", Length = "0x32")]
    private bool GetButton(Player player, int actionId) => false;

    [Token(Token = "0x6001237")]
    [Address(RVA = "0x3751E0", Offset = "0x373DE0", Length = "0x32")]
    private bool GetButtonDown(Player player, int actionId) => false;

    [Token(Token = "0x6001238")]
    [Address(RVA = "0x375410", Offset = "0x374010", Length = "0x32")]
    private bool GetNegativeButton(Player player, int actionId) => false;

    [Token(Token = "0x6001239")]
    [Address(RVA = "0x3753D0", Offset = "0x373FD0", Length = "0x32")]
    private bool GetNegativeButtonDown(Player player, int actionId) => false;

    [Token(Token = "0x600123A")]
    [Address(RVA = "0x3751A0", Offset = "0x373DA0", Length = "0x33")]
    private float GetAxis(Player player, int actionId) => 0.0f;

    [Token(Token = "0x600123B")]
    [Address(RVA = "0x374EB0", Offset = "0x373AB0", Length = "0xA4")]
    private void CheckEditorRecompile()
    {
    }

    [Token(Token = "0x600123C")]
    [Address(RVA = "0x375EB0", Offset = "0x374AB0", Length = "0xE")]
    private void OnEditorRecompile()
    {
    }

    [Token(Token = "0x600123D")]
    [Address(RVA = "0x374F60", Offset = "0x373B60", Length = "0x7C")]
    private void ClearRewiredVars()
    {
    }

    [Token(Token = "0x600123E")]
    [Address(RVA = "0x375000", Offset = "0x373C00", Length = "0x195")]
    private bool DidAnyMouseMove() => false;

    [Token(Token = "0x600123F")]
    [Address(RVA = "0x375260", Offset = "0x373E60", Length = "0x165")]
    private bool GetMouseButtonDownOnAnyMouse(int buttonIndex) => false;

    [Token(Token = "0x6001240")]
    [Address(RVA = "0x375EC0", Offset = "0x374AC0", Length = "0x7")]
    private void OnRewiredInitialized()
    {
    }

    [Token(Token = "0x6001241")]
    [Address(RVA = "0x375ED0", Offset = "0x374AD0", Length = "0x7")]
    private void OnRewiredShutDown()
    {
    }

    [Token(Token = "0x2000271")]
    [Serializable]
    public class PlayerSetting
    {
      [Token(Token = "0x40011B9")]
      [FieldOffset(Offset = "0x10")]
      public int playerId;
      [Token(Token = "0x40011BA")]
      [FieldOffset(Offset = "0x18")]
      public List<Rewired.Components.PlayerMouse> playerMice;

      [Token(Token = "0x6001242")]
      [Address(RVA = "0x3713C0", Offset = "0x36FFC0", Length = "0x77")]
      public PlayerSetting()
      {
      }

      [Token(Token = "0x6001243")]
      [Address(RVA = "0x371440", Offset = "0x370040", Length = "0x256")]
      private PlayerSetting(RewiredStandaloneInputModule.PlayerSetting other)
      {
      }

      [Token(Token = "0x6001244")]
      [Address(RVA = "0x371360", Offset = "0x36FF60", Length = "0x54")]
      public RewiredStandaloneInputModule.PlayerSetting Clone() => (RewiredStandaloneInputModule.PlayerSetting) null;
    }
  }
}
