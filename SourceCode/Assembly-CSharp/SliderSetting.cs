// Decompiled with JetBrains decompiler
// Type: SliderSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Settings___Saves.SaveFiles;
using Cpp2ILInjected;
using System;
using TMPro;
using UnityEngine.UI;

[Token(Token = "0x20001E1")]
public class SliderSetting : BetterSetting
{
  [Token(Token = "0x4000D7A")]
  [FieldOffset(Offset = "0x90")]
  public TMP_InputField valueText;
  [Token(Token = "0x4000D7B")]
  [FieldOffset(Offset = "0x98")]
  public Slider slider;
  [Token(Token = "0x4000D7C")]
  [FieldOffset(Offset = "0xA0")]
  private bool useWholeNumbers;

  [Token(Token = "0x6000C76")]
  [Address(RVA = "0x518160", Offset = "0x516D60", Length = "0xFB")]
  public override void SetSetting(
    Action<string, object, CFSettings> saveAction,
    string settingName,
    object currentValue,
    Settings settings,
    CFSettings cfSettings)
  {
  }

  [Token(Token = "0x6000C77")]
  [Address(RVA = "0x5184A0", Offset = "0x5170A0", Length = "0xD9")]
  public void UpdateValueSlider()
  {
  }

  [Token(Token = "0x6000C78")]
  [Address(RVA = "0x518380", Offset = "0x516F80", Length = "0x119")]
  public void UpdateValueInputField()
  {
  }

  [Token(Token = "0x6000C79")]
  [Address(RVA = "0x517EE0", Offset = "0x516AE0", Length = "0x23C")]
  public override void ControllerInputDir(int dir, float multiplier)
  {
  }

  [Token(Token = "0x6000C7A")]
  [Address(RVA = "0x518120", Offset = "0x516D20", Length = "0x3D")]
  private float GetValue() => 0.0f;

  [Token(Token = "0x6000C7B")]
  [Address(RVA = "0x518260", Offset = "0x516E60", Length = "0x11C")]
  protected override void ShowValue()
  {
  }

  [Token(Token = "0x6000C7C")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public SliderSetting()
  {
  }
}
