// Decompiled with JetBrains decompiler
// Type: MyButtonSetting
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200017E")]
public class MyButtonSetting : MyButton
{
  [Token(Token = "0x4000B08")]
  [FieldOffset(Offset = "0x58")]
  public BetterSetting betterSetting;
  [Token(Token = "0x4000B09")]
  [FieldOffset(Offset = "0x60")]
  public MaskableGraphic background;
  [Token(Token = "0x4000B0A")]
  [FieldOffset(Offset = "0x68")]
  public Color defaultColor;
  [Token(Token = "0x4000B0B")]
  [FieldOffset(Offset = "0x78")]
  public Color hoverColor;
  [Token(Token = "0x4000B0C")]
  [FieldOffset(Offset = "0x88")]
  public Action A_StartHover;
  [Token(Token = "0x4000B0D")]
  [FieldOffset(Offset = "0x90")]
  public Action A_StopHover;
  [Token(Token = "0x4000B0E")]
  [FieldOffset(Offset = "0x98")]
  private float nextUpdateTime;
  [Token(Token = "0x4000B0F")]
  [FieldOffset(Offset = "0x9C")]
  private int holdingDir;
  [Token(Token = "0x4000B10")]
  [FieldOffset(Offset = "0xA0")]
  private float cooldownTimer;
  [Token(Token = "0x4000B11")]
  [FieldOffset(Offset = "0xA4")]
  private float multiplier;
  [Token(Token = "0x4000B12")]
  [FieldOffset(Offset = "0xA8")]
  private float canUseHorizontalTime;

  [Token(Token = "0x60009A6")]
  [Address(RVA = "0x4DA060", Offset = "0x4D8C60", Length = "0x96")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x60009A7")]
  [Address(RVA = "0x4D9FF0", Offset = "0x4D8BF0", Length = "0x26")]
  private void ResetCanUseHorizontalTime()
  {
  }

  [Token(Token = "0x60009A8")]
  [Address(RVA = "0x4DA100", Offset = "0x4D8D00", Length = "0x5C")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x60009A9")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x60009AA")]
  [Address(RVA = "0x4DA160", Offset = "0x4D8D60", Length = "0x23C")]
  private new void Update()
  {
  }

  [Token(Token = "0x60009AB")]
  [Address(RVA = "0x4DA020", Offset = "0x4D8C20", Length = "0x32")]
  private void ResetCooldown()
  {
  }

  [Token(Token = "0x60009AC")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonSetting()
  {
  }
}
