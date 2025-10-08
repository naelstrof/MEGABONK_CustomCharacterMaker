// Decompiled with JetBrains decompiler
// Type: LanguageSettingButton
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20001FE")]
public class LanguageSettingButton : MonoBehaviour
{
  [Token(Token = "0x4000E13")]
  [FieldOffset(Offset = "0x20")]
  public BetterSetting betterSetting;

  [Token(Token = "0x6000D23")]
  [Address(RVA = "0x527E20", Offset = "0x526A20", Length = "0x140")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000D24")]
  [Address(RVA = "0x527F70", Offset = "0x526B70", Length = "0x140")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000D25")]
  [Address(RVA = "0x5280C0", Offset = "0x526CC0", Length = "0x62")]
  private void OnSettingUpdated(string settingName, object oldValue, object newValue)
  {
  }

  [Token(Token = "0x6000D26")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public LanguageSettingButton()
  {
  }
}
