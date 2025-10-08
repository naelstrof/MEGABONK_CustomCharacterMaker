// Decompiled with JetBrains decompiler
// Type: MyButtonShop
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

[Token(Token = "0x2000181")]
public class MyButtonShop : MyButtonNormal
{
  [Token(Token = "0x4000B17")]
  [FieldOffset(Offset = "0x88")]
  public ShopContainer shopContainer;
  [Token(Token = "0x4000B18")]
  public static Action<ShopContainer> A_Clicked;
  [Token(Token = "0x4000B19")]
  public static Action<ShopContainer> A_Select;

  [Token(Token = "0x60009B5")]
  [Address(RVA = "0x4DA490", Offset = "0x4D9090", Length = "0xD1")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x60009B6")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x60009B7")]
  [Address(RVA = "0x4DA3A0", Offset = "0x4D8FA0", Length = "0xE9")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x60009B8")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonShop()
  {
  }
}
