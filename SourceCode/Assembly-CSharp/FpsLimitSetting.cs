// Decompiled with JetBrains decompiler
// Type: FpsLimitSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

[Token(Token = "0x20001D0")]
public class FpsLimitSetting : MonoBehaviour
{
  [Token(Token = "0x4000D0E")]
  [FieldOffset(Offset = "0x20")]
  private BetterSetting betterSetting;

  [Token(Token = "0x6000BE3")]
  [Address(RVA = "0x505420", Offset = "0x504020", Length = "0x1BF")]
  private void Start()
  {
  }

  [Token(Token = "0x6000BE4")]
  [Address(RVA = "0x504E90", Offset = "0x503A90", Length = "0x18A")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000BE5")]
  [Address(RVA = "0x505030", Offset = "0x503C30", Length = "0x57")]
  private void OnSettingUpdated(string settingName, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x6000BE6")]
  [Address(RVA = "0x505020", Offset = "0x503C20", Length = "0x7")]
  private void OnLocaleChanged(Locale locale)
  {
  }

  [Token(Token = "0x6000BE7")]
  [Address(RVA = "0x505090", Offset = "0x503C90", Length = "0x384")]
  private void Refresh()
  {
  }

  [Token(Token = "0x6000BE8")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public FpsLimitSetting()
  {
  }
}
