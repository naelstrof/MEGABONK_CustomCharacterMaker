// Decompiled with JetBrains decompiler
// Type: MyButtonToggle
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x20001BB")]
public class MyButtonToggle : MyButton
{
  [Token(Token = "0x4000C99")]
  [FieldOffset(Offset = "0x58")]
  public Action<bool> A_Toggled;
  [Token(Token = "0x4000C9A")]
  [FieldOffset(Offset = "0x60")]
  public GameObject toggleIcon;

  [Token(Token = "0x6000B32")]
  [Address(RVA = "0x50CF50", Offset = "0x50BB50", Length = "0x1E")]
  public void Set(bool on)
  {
  }

  [Token(Token = "0x6000B33")]
  [Address(RVA = "0x4FB1D0", Offset = "0x4F9DD0", Length = "0x1D")]
  public bool IsOn() => false;

  [Token(Token = "0x6000B34")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000B35")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000B36")]
  [Address(RVA = "0x50CEE0", Offset = "0x50BAE0", Length = "0x67")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000B37")]
  [Address(RVA = "0x4F0AE0", Offset = "0x4EF6E0", Length = "0x7")]
  public MyButtonToggle()
  {
  }
}
