// Decompiled with JetBrains decompiler
// Type: Rewired.Utils.ExternalTools
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;

namespace Rewired.Utils
{
  [EditorBrowsable(EditorBrowsableState.Never)]
  [Token(Token = "0x2000245")]
  public class ExternalTools : IExternalTools
  {
    [Token(Token = "0x40010FF")]
    private static Func<object> _getPlatformInitializerDelegate;
    [Token(Token = "0x4001100")]
    [FieldOffset(Offset = "0x10")]
    private bool _isEditorPaused;
    [Token(Token = "0x4001101")]
    [FieldOffset(Offset = "0x18")]
    private Action<bool> _EditorPausedStateChangedEvent;

    [Token(Token = "0x1700027D")]
    public static Func<object> getPlatformInitializerDelegate
    {
      [Token(Token = "0x600104E"), Address(RVA = "0x521FC0", Offset = "0x520BC0", Length = "0x36")] get => (Func<object>) null;
      [Token(Token = "0x600104F"), Address(RVA = "0x522160", Offset = "0x520D60", Length = "0x51")] set
      {
      }
    }

    [Token(Token = "0x6001050")]
    [Address(RVA = "0x351750", Offset = "0x350350", Length = "0x7")]
    public ExternalTools()
    {
    }

    [Token(Token = "0x6001051")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public void Destroy()
    {
    }

    [Token(Token = "0x1700027E")]
    public bool isEditorPaused
    {
      [Token(Token = "0x6001052"), Address(RVA = "0x36C9C0", Offset = "0x36B5C0", Length = "0x5")] get => false;
    }

    [Token(Token = "0x14000004")]
    public event Action<bool> EditorPausedStateChangedEvent
    {
      [Token(Token = "0x6001053"), Address(RVA = "0x521E50", Offset = "0x520A50", Length = "0xAF")] add
      {
      }
      [Token(Token = "0x6001054"), Address(RVA = "0x522000", Offset = "0x520C00", Length = "0xAF")] remove
      {
      }
    }

    [Token(Token = "0x6001055")]
    [Address(RVA = "0x521BB0", Offset = "0x5207B0", Length = "0x7")]
    public object GetPlatformInitializer() => (object) null;

    [Token(Token = "0x6001056")]
    [Address(RVA = "0x521B90", Offset = "0x520790", Length = "0x12")]
    public string GetFocusedEditorWindowTitle() => (string) null;

    [Token(Token = "0x6001057")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    public bool IsEditorSceneViewFocused() => false;

    [Token(Token = "0x6001058")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    public bool LinuxInput_IsJoystickPreconfigured(string name) => false;

    [Token(Token = "0x14000005")]
    public event Action<uint, bool> XboxOneInput_OnGamepadStateChange
    {
      [Token(Token = "0x6001059"), Address(RVA = "0x521F00", Offset = "0x520B00", Length = "0xAC")] add
      {
      }
      [Token(Token = "0x600105A"), Address(RVA = "0x5220B0", Offset = "0x520CB0", Length = "0xAC")] remove
      {
      }
    }

    [Token(Token = "0x600105B")]
    [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
    public int XboxOneInput_GetUserIdForGamepad(uint id) => 0;

    [Token(Token = "0x600105C")]
    [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
    public ulong XboxOneInput_GetControllerId(uint unityJoystickId) => 0;

    [Token(Token = "0x600105D")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    public bool XboxOneInput_IsGamepadActive(uint unityJoystickId) => false;

    [Token(Token = "0x600105E")]
    [Address(RVA = "0x521B90", Offset = "0x520790", Length = "0x12")]
    public string XboxOneInput_GetControllerType(ulong xboxControllerId) => (string) null;

    [Token(Token = "0x600105F")]
    [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
    public uint XboxOneInput_GetJoystickId(ulong xboxControllerId) => 0;

    [Token(Token = "0x6001060")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public void XboxOne_Gamepad_UpdatePlugin()
    {
    }

    [Token(Token = "0x6001061")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    public bool XboxOne_Gamepad_SetGamepadVibration(
      ulong xboxOneJoystickId,
      float leftMotor,
      float rightMotor,
      float leftTriggerLevel,
      float rightTriggerLevel)
    {
      return false;
    }

    [Token(Token = "0x6001062")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    public void XboxOne_Gamepad_PulseVibrateMotor(
      ulong xboxOneJoystickId,
      int motorInt,
      float startLevel,
      float endLevel,
      ulong durationMS)
    {
    }

    [Token(Token = "0x6001063")]
    [Address(RVA = "0x521AE0", Offset = "0x5206E0", Length = "0xA4")]
    public void GetDeviceVIDPIDs(out List<int> vids, out List<int> pids)
    {
      vids = (List<int>) null;
      pids = (List<int>) null;
    }

    [Token(Token = "0x6001064")]
    [Address(RVA = "0x5219B0", Offset = "0x5205B0", Length = "0x6")]
    public int GetAndroidAPILevel() => 0;

    [Token(Token = "0x6001065")]
    [Address(RVA = "0x521E20", Offset = "0x520A20", Length = "0x2D")]
    public void WindowsStandalone_ForwardRawInput(
      IntPtr rawInputHeaderIndices,
      IntPtr rawInputDataIndices,
      uint indicesCount,
      IntPtr rawInputData,
      uint rawInputDataSize)
    {
    }

    [Token(Token = "0x6001066")]
    [Address(RVA = "0x521BE0", Offset = "0x5207E0", Length = "0x118")]
    public bool UnityUI_Graphic_GetRaycastTarget(object graphic) => false;

    [Token(Token = "0x6001067")]
    [Address(RVA = "0x521D00", Offset = "0x520900", Length = "0x119")]
    public void UnityUI_Graphic_SetRaycastTarget(object graphic, bool value)
    {
    }

    [Token(Token = "0x1700027F")]
    public bool UnityInput_IsTouchPressureSupported
    {
      [Token(Token = "0x6001068"), Address(RVA = "0x521FB0", Offset = "0x520BB0", Length = "0x7")] get => false;
    }

    [Token(Token = "0x6001069")]
    [Address(RVA = "0x521BD0", Offset = "0x5207D0", Length = "0xA")]
    public float UnityInput_GetTouchPressure(ref Touch touch) => 0.0f;

    [Token(Token = "0x600106A")]
    [Address(RVA = "0x521BC0", Offset = "0x5207C0", Length = "0xA")]
    public float UnityInput_GetTouchMaximumPossiblePressure(ref Touch touch) => 0.0f;

    [Token(Token = "0x600106B")]
    [Address(RVA = "0x521940", Offset = "0x520540", Length = "0x64")]
    public IControllerTemplate CreateControllerTemplate(Guid typeGuid, object payload) => (IControllerTemplate) null;

    [Token(Token = "0x600106C")]
    [Address(RVA = "0x521A50", Offset = "0x520650", Length = "0x89")]
    public System.Type[] GetControllerTemplateTypes() => (System.Type[]) null;

    [Token(Token = "0x600106D")]
    [Address(RVA = "0x5219C0", Offset = "0x5205C0", Length = "0x8A")]
    public System.Type[] GetControllerTemplateInterfaceTypes() => (System.Type[]) null;
  }
}
