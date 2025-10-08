// Decompiled with JetBrains decompiler
// Type: ResizeOnLocalization
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization.Components;

[Token(Token = "0x2000173")]
public class ResizeOnLocalization : MonoBehaviour
{
  [Token(Token = "0x4000AB7")]
  [FieldOffset(Offset = "0x20")]
  public Transform rebuildTransform;
  [Token(Token = "0x4000AB8")]
  [FieldOffset(Offset = "0x28")]
  public LocalizeStringEvent localizeStringEvent;
  [Token(Token = "0x4000AB9")]
  [FieldOffset(Offset = "0x30")]
  public TextSizer textSizer;
  [Token(Token = "0x4000ABA")]
  [FieldOffset(Offset = "0x38")]
  public ButtonTextWrapper buttonTextWrapper;
  [Token(Token = "0x4000ABB")]
  [FieldOffset(Offset = "0x40")]
  private bool expectingRebuild;
  [Token(Token = "0x4000ABC")]
  [FieldOffset(Offset = "0x41")]
  private bool expectingRefresh;

  [Token(Token = "0x6000959")]
  [Address(RVA = "0x4DCD60", Offset = "0x4DB960", Length = "0xC9")]
  private void Start()
  {
  }

  [Token(Token = "0x600095A")]
  [Address(RVA = "0x4DCA50", Offset = "0x4DB650", Length = "0xC9")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x600095B")]
  [Address(RVA = "0x4DCB20", Offset = "0x4DB720", Length = "0x72")]
  private void OnEnable()
  {
  }

  [Token(Token = "0x600095C")]
  [Address(RVA = "0x4DCBA0", Offset = "0x4DB7A0", Length = "0x66")]
  private void OnLocalizedStringChanged(string updatedString)
  {
  }

  [Token(Token = "0x600095D")]
  [Address(RVA = "0x4DC900", Offset = "0x4DB500", Length = "0x145")]
  private void DelayedRefresh()
  {
  }

  [Token(Token = "0x600095E")]
  [Address(RVA = "0x4DCD50", Offset = "0x4DB950", Length = "0xF")]
  private void Rebuild()
  {
  }

  [Token(Token = "0x600095F")]
  [Address(RVA = "0x4DCC10", Offset = "0x4DB810", Length = "0x133")]
  private void OnValidate()
  {
  }

  [Token(Token = "0x6000960")]
  [Address(RVA = "0x338C30", Offset = "0x337830", Length = "0x7")]
  public ResizeOnLocalization()
  {
  }
}
