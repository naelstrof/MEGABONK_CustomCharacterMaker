// Decompiled with JetBrains decompiler
// Type: Rewired.Integration.UnityUI.RewiredPointerInputModule
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Rewired.Integration.UnityUI
{
  [Token(Token = "0x200026A")]
  public abstract class RewiredPointerInputModule : BaseInputModule
  {
    [Token(Token = "0x400117F")]
    public const int kMouseLeftId = -1;
    [Token(Token = "0x4001180")]
    public const int kMouseRightId = -2;
    [Token(Token = "0x4001181")]
    public const int kMouseMiddleId = -3;
    [Token(Token = "0x4001182")]
    public const int kFakeTouchesId = -4;
    [Token(Token = "0x4001183")]
    private const int customButtonsStartingId = -2147483520;
    [Token(Token = "0x4001184")]
    private const int customButtonsMaxCount = 128;
    [Token(Token = "0x4001185")]
    private const int customButtonsLastId = -2147483392;
    [Token(Token = "0x4001186")]
    [FieldOffset(Offset = "0x58")]
    private readonly List<IMouseInputSource> m_MouseInputSourcesList;
    [Token(Token = "0x4001187")]
    [FieldOffset(Offset = "0x60")]
    private Dictionary<int, Dictionary<int, PlayerPointerEventData>[]> m_PlayerPointerData;
    [Token(Token = "0x4001188")]
    [FieldOffset(Offset = "0x68")]
    private ITouchInputSource m_UserDefaultTouchInputSource;
    [Token(Token = "0x4001189")]
    [FieldOffset(Offset = "0x70")]
    private RewiredPointerInputModule.UnityInputSource __m_DefaultInputSource;
    [Token(Token = "0x400118A")]
    [FieldOffset(Offset = "0x78")]
    private readonly RewiredPointerInputModule.MouseState m_MouseState;

    [Token(Token = "0x170002AB")]
    private RewiredPointerInputModule.UnityInputSource defaultInputSource
    {
      [Token(Token = "0x60011AB"), Address(RVA = "0x3749C0", Offset = "0x3735C0", Length = "0x79")] get => (RewiredPointerInputModule.UnityInputSource) null;
    }

    [Token(Token = "0x170002AC")]
    private IMouseInputSource defaultMouseInputSource
    {
      [Token(Token = "0x60011AC"), Address(RVA = "0x374A40", Offset = "0x373640", Length = "0x7")] get => (IMouseInputSource) null;
    }

    [Token(Token = "0x170002AD")]
    protected ITouchInputSource defaultTouchInputSource
    {
      [Token(Token = "0x60011AD"), Address(RVA = "0x374A40", Offset = "0x373640", Length = "0x7")] get => (ITouchInputSource) null;
    }

    [Token(Token = "0x60011AE")]
    [Address(RVA = "0x373A50", Offset = "0x372650", Length = "0x1C")]
    protected bool IsDefaultMouse(IMouseInputSource mouse) => false;

    [Token(Token = "0x60011AF")]
    [Address(RVA = "0x372470", Offset = "0x371070", Length = "0x1BB")]
    public IMouseInputSource GetMouseInputSource(int playerId, int mouseIndex) => (IMouseInputSource) null;

    [Token(Token = "0x60011B0")]
    [Address(RVA = "0x3740B0", Offset = "0x372CB0", Length = "0xA1")]
    public void RemoveMouseInputSource(IMouseInputSource source)
    {
    }

    [Token(Token = "0x60011B1")]
    [Address(RVA = "0x371840", Offset = "0x370440", Length = "0x13B")]
    public void AddMouseInputSource(IMouseInputSource source)
    {
    }

    [Token(Token = "0x60011B2")]
    [Address(RVA = "0x372320", Offset = "0x370F20", Length = "0x145")]
    public int GetMouseInputSourceCount(int playerId) => 0;

    [Token(Token = "0x60011B3")]
    [Address(RVA = "0x3736E0", Offset = "0x3722E0", Length = "0x84")]
    public ITouchInputSource GetTouchInputSource(int playerId, int sourceIndex) => (ITouchInputSource) null;

    [Token(Token = "0x60011B4")]
    [Address(RVA = "0x374220", Offset = "0x372E20", Length = "0x7D")]
    public void RemoveTouchInputSource(ITouchInputSource source)
    {
    }

    [Token(Token = "0x60011B5")]
    [Address(RVA = "0x371980", Offset = "0x370580", Length = "0xC2")]
    public void AddTouchInputSource(ITouchInputSource source)
    {
    }

    [Token(Token = "0x60011B6")]
    [Address(RVA = "0x3736B0", Offset = "0x3722B0", Length = "0x25")]
    public int GetTouchInputSourceCount(int playerId) => 0;

    [Token(Token = "0x60011B7")]
    [Address(RVA = "0x371A50", Offset = "0x370650", Length = "0x5F")]
    protected void ClearMouseInputSources()
    {
    }

    [Token(Token = "0x170002AE")]
    protected virtual bool isMouseSupported
    {
      [Token(Token = "0x60011B8"), Address(RVA = "0x374A50", Offset = "0x373650", Length = "0xFA")] get => false;
    }

    [Token(Token = "0x60011B9")]
    protected abstract bool IsDefaultPlayer(int playerId);

    [Token(Token = "0x60011BA")]
    [Address(RVA = "0x373030", Offset = "0x371C30", Length = "0x678")]
    protected bool GetPointerData(
      int playerId,
      int pointerIndex,
      int pointerTypeId,
      out PlayerPointerEventData data,
      bool create,
      PointerEventType pointerEventType)
    {
      data = (PlayerPointerEventData) null;
      return false;
    }

    [Token(Token = "0x60011BB")]
    [Address(RVA = "0x371EF0", Offset = "0x370AF0", Length = "0x141")]
    private PlayerPointerEventData CreatePointerEventData(
      int playerId,
      int pointerIndex,
      int pointerTypeId,
      PointerEventType pointerEventType)
    {
      return (PlayerPointerEventData) null;
    }

    [Token(Token = "0x60011BC")]
    [Address(RVA = "0x374160", Offset = "0x372D60", Length = "0xB2")]
    protected void RemovePointerData(PlayerPointerEventData data)
    {
    }

    [Token(Token = "0x60011BD")]
    [Address(RVA = "0x373770", Offset = "0x372370", Length = "0x2D3")]
    protected PlayerPointerEventData GetTouchPointerEventData(
      int playerId,
      int touchDeviceIndex,
      Touch input,
      out bool pressed,
      out bool released)
    {
      pressed = new bool();
      released = new bool();
      return (PlayerPointerEventData) null;
    }

    [Token(Token = "0x60011BE")]
    [Address(RVA = "0x372630", Offset = "0x371230", Length = "0x9F4")]
    protected virtual RewiredPointerInputModule.MouseState GetMousePointerEventData(
      int playerId,
      int mouseIndex)
    {
      return (RewiredPointerInputModule.MouseState) null;
    }

    [Token(Token = "0x60011BF")]
    [Address(RVA = "0x372120", Offset = "0x370D20", Length = "0x1F6")]
    protected PlayerPointerEventData GetLastPointerEventData(
      int playerId,
      int pointerIndex,
      int pointerTypeId,
      bool ignorePointerTypeId,
      PointerEventType pointerEventType)
    {
      return (PlayerPointerEventData) null;
    }

    [Token(Token = "0x60011C0")]
    [Address(RVA = "0x3742A0", Offset = "0x372EA0", Length = "0x4B")]
    private static bool ShouldStartDrag(
      Vector2 pressPos,
      Vector2 currentPos,
      float threshold,
      bool useDragThreshold)
    {
      return false;
    }

    [Token(Token = "0x60011C1")]
    [Address(RVA = "0x373F90", Offset = "0x372B90", Length = "0x113")]
    protected virtual void ProcessMove(PlayerPointerEventData pointerEvent)
    {
    }

    [Token(Token = "0x60011C2")]
    [Address(RVA = "0x373C70", Offset = "0x372870", Length = "0x310")]
    protected virtual void ProcessDrag(PlayerPointerEventData pointerEvent)
    {
    }

    [Token(Token = "0x60011C3")]
    [Address(RVA = "0x373A70", Offset = "0x372670", Length = "0x1FE")]
    public override bool IsPointerOverGameObject(int pointerTypeId) => false;

    [Token(Token = "0x60011C4")]
    [Address(RVA = "0x371AB0", Offset = "0x3706B0", Length = "0x34A")]
    protected void ClearSelection()
    {
    }

    [Token(Token = "0x60011C5")]
    [Address(RVA = "0x3743C0", Offset = "0x372FC0", Length = "0x49B")]
    public override string ToString() => (string) null;

    [Token(Token = "0x60011C6")]
    [Address(RVA = "0x372040", Offset = "0x370C40", Length = "0xDC")]
    protected void DeselectIfSelectionChanged(GameObject currentOverGo, BaseEventData pointerEvent)
    {
    }

    [Token(Token = "0x60011C7")]
    [Address(RVA = "0x371E00", Offset = "0x370A00", Length = "0xEC")]
    protected void CopyFromTo(PointerEventData from, PointerEventData to)
    {
    }

    [Token(Token = "0x60011C8")]
    [Address(RVA = "0x3742F0", Offset = "0x372EF0", Length = "0xC7")]
    protected PointerEventData.FramePressState StateForMouseButton(
      int playerId,
      int mouseIndex,
      int buttonId)
    {
      return new PointerEventData.FramePressState();
    }

    [Token(Token = "0x60011C9")]
    [Address(RVA = "0x374860", Offset = "0x373460", Length = "0x152")]
    protected RewiredPointerInputModule()
    {
    }

    [Token(Token = "0x200026B")]
    protected class MouseState
    {
      [Token(Token = "0x400118B")]
      [FieldOffset(Offset = "0x10")]
      private List<RewiredPointerInputModule.ButtonState> m_TrackedButtons;

      [Token(Token = "0x60011CA")]
      [Address(RVA = "0x370B10", Offset = "0x36F710", Length = "0xA6")]
      public bool AnyPressesThisFrame() => false;

      [Token(Token = "0x60011CB")]
      [Address(RVA = "0x370BC0", Offset = "0x36F7C0", Length = "0xA6")]
      public bool AnyReleasesThisFrame() => false;

      [Token(Token = "0x60011CC")]
      [Address(RVA = "0x370C70", Offset = "0x36F870", Length = "0x1AF")]
      public RewiredPointerInputModule.ButtonState GetButtonState(int button) => (RewiredPointerInputModule.ButtonState) null;

      [Token(Token = "0x60011CD")]
      [Address(RVA = "0x370E20", Offset = "0x36FA20", Length = "0x51")]
      public void SetButtonState(
        int button,
        PointerEventData.FramePressState stateForMouseButton,
        PlayerPointerEventData data)
      {
      }

      [Token(Token = "0x60011CE")]
      [Address(RVA = "0x370E80", Offset = "0x36FA80", Length = "0x77")]
      public MouseState()
      {
      }
    }

    [Token(Token = "0x200026C")]
    public class MouseButtonEventData
    {
      [Token(Token = "0x400118C")]
      [FieldOffset(Offset = "0x10")]
      public PointerEventData.FramePressState buttonState;
      [Token(Token = "0x400118D")]
      [FieldOffset(Offset = "0x18")]
      public PlayerPointerEventData buttonData;

      [Token(Token = "0x60011CF")]
      [Address(RVA = "0x370AD0", Offset = "0x36F6D0", Length = "0x11")]
      public bool PressedThisFrame() => false;

      [Token(Token = "0x60011D0")]
      [Address(RVA = "0x370AF0", Offset = "0x36F6F0", Length = "0x11")]
      public bool ReleasedThisFrame() => false;

      [Token(Token = "0x60011D1")]
      [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
      public MouseButtonEventData()
      {
      }
    }

    [Token(Token = "0x200026D")]
    protected class ButtonState
    {
      [Token(Token = "0x400118E")]
      [FieldOffset(Offset = "0x10")]
      private int m_Button;
      [Token(Token = "0x400118F")]
      [FieldOffset(Offset = "0x18")]
      private RewiredPointerInputModule.MouseButtonEventData m_EventData;

      [Token(Token = "0x170002AF")]
      public RewiredPointerInputModule.MouseButtonEventData eventData
      {
        [Token(Token = "0x60011D2"), Address(RVA = "0x3684A0", Offset = "0x3670A0", Length = "0x5")] get => (RewiredPointerInputModule.MouseButtonEventData) null;
        [Token(Token = "0x60011D3"), Address(RVA = "0x36AC70", Offset = "0x369870", Length = "0xD")] set
        {
        }
      }

      [Token(Token = "0x170002B0")]
      public int button
      {
        [Token(Token = "0x60011D4"), Address(RVA = "0x36AC50", Offset = "0x369850", Length = "0x4")] get => 0;
        [Token(Token = "0x60011D5"), Address(RVA = "0x36AC60", Offset = "0x369860", Length = "0x4")] set
        {
        }
      }

      [Token(Token = "0x60011D6")]
      [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
      public ButtonState()
      {
      }
    }

    [Token(Token = "0x200026E")]
    private sealed class UnityInputSource : IMouseInputSource, ITouchInputSource
    {
      [Token(Token = "0x4001190")]
      [FieldOffset(Offset = "0x10")]
      private Vector2 m_MousePosition;
      [Token(Token = "0x4001191")]
      [FieldOffset(Offset = "0x18")]
      private Vector2 m_MousePositionPrev;
      [Token(Token = "0x4001192")]
      [FieldOffset(Offset = "0x20")]
      private int m_LastUpdatedFrame;

      [Token(Token = "0x170002B1")]
      int IMouseInputSource.playerId
      {
        [Token(Token = "0x60011D7"), Address(RVA = "0x37BF00", Offset = "0x37AB00", Length = "0x5C")] get => 0;
      }

      [Token(Token = "0x170002B2")]
      int ITouchInputSource.playerId
      {
        [Token(Token = "0x60011D8"), Address(RVA = "0x37BF00", Offset = "0x37AB00", Length = "0x5C")] get => 0;
      }

      [Token(Token = "0x170002B3")]
      bool IMouseInputSource.enabled
      {
        [Token(Token = "0x60011D9"), Address(RVA = "0x37BE30", Offset = "0x37AA30", Length = "0x60")] get => false;
      }

      [Token(Token = "0x170002B4")]
      bool IMouseInputSource.locked
      {
        [Token(Token = "0x60011DA"), Address(RVA = "0x37BE90", Offset = "0x37AA90", Length = "0x67")] get => false;
      }

      [Token(Token = "0x170002B5")]
      int IMouseInputSource.buttonCount
      {
        [Token(Token = "0x60011DB"), Address(RVA = "0x37BDD0", Offset = "0x37A9D0", Length = "0x5F")] get => 0;
      }

      [Token(Token = "0x60011DC")]
      [Address(RVA = "0x37BC80", Offset = "0x37A880", Length = "0x6D")]
      bool IMouseInputSource.GetButtonDown(int button) => false;

      [Token(Token = "0x60011DD")]
      [Address(RVA = "0x37BCF0", Offset = "0x37A8F0", Length = "0x6D")]
      bool IMouseInputSource.GetButtonUp(int button) => false;

      [Token(Token = "0x60011DE")]
      [Address(RVA = "0x37BD60", Offset = "0x37A960", Length = "0x6D")]
      bool IMouseInputSource.GetButton(int button) => false;

      [Token(Token = "0x170002B6")]
      Vector2 IMouseInputSource.screenPosition
      {
        [Token(Token = "0x60011DF"), Address(RVA = "0x37BFE0", Offset = "0x37ABE0", Length = "0x86")] get => new Vector2();
      }

      [Token(Token = "0x170002B7")]
      Vector2 IMouseInputSource.screenPositionDelta
      {
        [Token(Token = "0x60011E0"), Address(RVA = "0x37BF60", Offset = "0x37AB60", Length = "0x76")] get => new Vector2();
      }

      [Token(Token = "0x170002B8")]
      Vector2 IMouseInputSource.wheelDelta
      {
        [Token(Token = "0x60011E1"), Address(RVA = "0x37C070", Offset = "0x37AC70", Length = "0x60")] get => new Vector2();
      }

      [Token(Token = "0x170002B9")]
      bool ITouchInputSource.touchSupported
      {
        [Token(Token = "0x60011E2"), Address(RVA = "0x37C1F0", Offset = "0x37ADF0", Length = "0x60")] get => false;
      }

      [Token(Token = "0x170002BA")]
      int ITouchInputSource.touchCount
      {
        [Token(Token = "0x60011E3"), Address(RVA = "0x37C190", Offset = "0x37AD90", Length = "0x60")] get => 0;
      }

      [Token(Token = "0x60011E4")]
      [Address(RVA = "0x37C0D0", Offset = "0x37ACD0", Length = "0xB1")]
      Touch ITouchInputSource.GetTouch(int index) => new Touch();

      [Token(Token = "0x60011E5")]
      [Address(RVA = "0x37C250", Offset = "0x37AE50", Length = "0x5A")]
      private void TryUpdate()
      {
      }

      [Token(Token = "0x60011E6")]
      [Address(RVA = "0x37C2B0", Offset = "0x37AEB0", Length = "0xE")]
      public UnityInputSource()
      {
      }
    }
  }
}
