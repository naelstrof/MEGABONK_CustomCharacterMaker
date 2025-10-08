// Decompiled with JetBrains decompiler
// Type: LanguageButtonMenu
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

[Token(Token = "0x20001FD")]
public class LanguageButtonMenu : MonoBehaviour
{
  [Token(Token = "0x4000E10")]
  [FieldOffset(Offset = "0x20")]
  public TextMeshProUGUI languageText;
  [Token(Token = "0x4000E11")]
  [FieldOffset(Offset = "0x28")]
  public TextSizer textSizer;
  [Token(Token = "0x4000E12")]
  [FieldOffset(Offset = "0x30")]
  public ButtonTextWrapper buttonTextWrapper;

  [Token(Token = "0x6000D1D")]
  [Address(RVA = "0x527C90", Offset = "0x526890", Length = "0x8B")]
  private void Start()
  {
  }

  [Token(Token = "0x6000D1E")]
  [Address(RVA = "0x527A50", Offset = "0x526650", Length = "0x6D")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000D1F")]
  [Address(RVA = "0x527B90", Offset = "0x526790", Length = "0x6D")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000D20")]
  [Address(RVA = "0x527C00", Offset = "0x526800", Length = "0x84")]
  private void OnLocaleChanged(Locale newLocale)
  {
  }

  [Token(Token = "0x6000D21")]
  [Address(RVA = "0x527AC0", Offset = "0x5266C0", Length = "0xC6")]
  private void DelayedRefresh()
  {
  }

  [Token(Token = "0x6000D22")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public LanguageButtonMenu()
  {
  }
}
