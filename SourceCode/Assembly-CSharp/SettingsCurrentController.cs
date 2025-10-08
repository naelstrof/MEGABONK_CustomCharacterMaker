// Decompiled with JetBrains decompiler
// Type: SettingsCurrentController
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using Rewired;
using TMPro;
using UnityEngine;

[Token(Token = "0x20001E0")]
public class SettingsCurrentController : MonoBehaviour
{
  [Token(Token = "0x4000D79")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI t_controller;

  [Token(Token = "0x6000C70")]
  [Address(RVA = "0x5140A0", Offset = "0x512CA0", Length = "0x128")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000C71")]
  [Address(RVA = "0x5141E0", Offset = "0x512DE0", Length = "0x128")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000C72")]
  [Address(RVA = "0x5141D0", Offset = "0x512DD0", Length = "0x7")]
  private void OnControllerChange(Controller c)
  {
  }

  [Token(Token = "0x6000C73")]
  [Address(RVA = "0x5141D0", Offset = "0x512DD0", Length = "0x7")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x6000C74")]
  [Address(RVA = "0x514310", Offset = "0x512F10", Length = "0xDA")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000C75")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public SettingsCurrentController()
  {
  }
}
