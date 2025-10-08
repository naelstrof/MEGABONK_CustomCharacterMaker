// Decompiled with JetBrains decompiler
// Type: LocalizationPrewarmer
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Localization;

[Token(Token = "0x20000D8")]
public class LocalizationPrewarmer : MonoBehaviour
{
  [Header("Font Assets per script group")]
  [Token(Token = "0x4000733")]
  [FieldOffset(Offset = "0x20")]
  public TMP_FontAsset mainFont;
  [Token(Token = "0x4000734")]
  [FieldOffset(Offset = "0x28")]
  public TMP_FontAsset notoDefault;
  [Token(Token = "0x4000735")]
  [FieldOffset(Offset = "0x30")]
  public TMP_FontAsset notoJp;
  [Token(Token = "0x4000736")]
  [FieldOffset(Offset = "0x38")]
  public TMP_FontAsset notoKo;
  [Token(Token = "0x4000737")]
  [FieldOffset(Offset = "0x40")]
  public TMP_FontAsset notoSc;
  [Token(Token = "0x4000738")]
  [FieldOffset(Offset = "0x48")]
  public TMP_FontAsset notoTc;
  [Token(Token = "0x4000739")]
  [FieldOffset(Offset = "0x50")]
  public TMP_FontAsset notoTh;
  [Token(Token = "0x400073A")]
  [FieldOffset(Offset = "0x58")]
  public List<string> tableNamesToPreload;

  [Token(Token = "0x6000617")]
  [Address(RVA = "0x49E130", Offset = "0x49CD30", Length = "0x130")]
  private void Start()
  {
  }

  [Token(Token = "0x6000618")]
  [Address(RVA = "0x49D640", Offset = "0x49C240", Length = "0x6D")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000619")]
  [Address(RVA = "0x49D6B0", Offset = "0x49C2B0", Length = "0xE0")]
  private void OnLocaleChanged(Locale locale)
  {
  }

  [Token(Token = "0x600061A")]
  [Address(RVA = "0x49D790", Offset = "0x49C390", Length = "0x50E")]
  public void PrewarmFontAsset(TMP_FontAsset fontAsset, Locale locale)
  {
  }

  [Token(Token = "0x600061B")]
  [Address(RVA = "0x49DCA0", Offset = "0x49C8A0", Length = "0x482")]
  private void SortFallbacks(TMP_FontAsset fontAsset)
  {
  }

  [Token(Token = "0x600061C")]
  [Address(RVA = "0x49D470", Offset = "0x49C070", Length = "0x1C8")]
  private TMP_FontAsset GetFontAsset(Locale locale) => (TMP_FontAsset) null;

  [Token(Token = "0x600061D")]
  [Address(RVA = "0x49E260", Offset = "0x49CE60", Length = "0x77")]
  public LocalizationPrewarmer()
  {
  }
}
