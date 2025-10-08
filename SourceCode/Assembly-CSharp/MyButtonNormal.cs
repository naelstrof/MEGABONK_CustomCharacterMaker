// Decompiled with JetBrains decompiler
// Type: MyButtonNormal
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x200017A")]
public class MyButtonNormal : MyButton
{
  [Token(Token = "0x4000AE4")]
  [FieldOffset(Offset = "0x58")]
  public MaskableGraphic background;
  [Token(Token = "0x4000AE5")]
  [FieldOffset(Offset = "0x60")]
  public Color defaultColor;
  [Token(Token = "0x4000AE6")]
  [FieldOffset(Offset = "0x70")]
  public Color hoverColor;
  [Token(Token = "0x4000AE7")]
  [FieldOffset(Offset = "0x80")]
  private bool colorInited;

  [Token(Token = "0x6000985")]
  [Address(RVA = "0x4D86B0", Offset = "0x4D72B0", Length = "0x55")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x6000986")]
  [Address(RVA = "0x4D8710", Offset = "0x4D7310", Length = "0x55")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x6000987")]
  [Address(RVA = "0x4D8590", Offset = "0x4D7190", Length = "0x110")]
  private void SetColor(Color c)
  {
  }

  [Token(Token = "0x6000988")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x6000989")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonNormal()
  {
  }
}
