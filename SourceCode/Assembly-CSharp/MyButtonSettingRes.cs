// Decompiled with JetBrains decompiler
// Type: MyButtonSettingRes
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x2000180")]
public class MyButtonSettingRes : MyButton
{
  [Token(Token = "0x4000B13")]
  [FieldOffset(Offset = "0x58")]
  public MaskableGraphic background;
  [Token(Token = "0x4000B14")]
  [FieldOffset(Offset = "0x60")]
  public Color defaultColor;
  [Token(Token = "0x4000B15")]
  [FieldOffset(Offset = "0x70")]
  public Color hoverColor;
  [Token(Token = "0x4000B16")]
  public static Action A_Clicked;

  [Token(Token = "0x60009B1")]
  [Address(RVA = "0x4D9F70", Offset = "0x4D8B70", Length = "0x3F")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x60009B2")]
  [Address(RVA = "0x4D9FB0", Offset = "0x4D8BB0", Length = "0x3F")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x60009B3")]
  [Address(RVA = "0x4D9F20", Offset = "0x4D8B20", Length = "0x4B")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x60009B4")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonSettingRes()
  {
  }
}
