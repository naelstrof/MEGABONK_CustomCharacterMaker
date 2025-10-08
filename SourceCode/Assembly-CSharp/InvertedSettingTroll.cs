// Decompiled with JetBrains decompiler
// Type: InvertedSettingTroll
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001D1")]
public class InvertedSettingTroll : MonoBehaviour
{
  [Token(Token = "0x4000D0F")]
  [FieldOffset(Offset = "0x20")]
  private BetterSetting betterSetting;
  [Token(Token = "0x4000D10")]
  private static int trollStage;
  [Token(Token = "0x4000D11")]
  [FieldOffset(Offset = "0x28")]
  private float startedTrollingTime;
  [Token(Token = "0x4000D12")]
  [FieldOffset(Offset = "0x2C")]
  private float trollCooldownSeconds;

  [Token(Token = "0x6000BE9")]
  [Address(RVA = "0x509640", Offset = "0x508240", Length = "0x175")]
  private void Start()
  {
  }

  [Token(Token = "0x6000BEA")]
  [Address(RVA = "0x509200", Offset = "0x507E00", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000BEB")]
  [Address(RVA = "0x509350", Offset = "0x507F50", Length = "0x57")]
  private void OnSettingUpdated(string settingName, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x6000BEC")]
  [Address(RVA = "0x5093B0", Offset = "0x507FB0", Length = "0x281")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000BED")]
  [Address(RVA = "0x5097C0", Offset = "0x5083C0", Length = "0xE")]
  public InvertedSettingTroll()
  {
  }
}
