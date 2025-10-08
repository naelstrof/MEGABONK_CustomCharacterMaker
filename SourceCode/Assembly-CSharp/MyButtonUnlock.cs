// Decompiled with JetBrains decompiler
// Type: MyButtonUnlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System;

[Token(Token = "0x2000184")]
public class MyButtonUnlock : MyButtonNormal
{
  [Token(Token = "0x4000B26")]
  [FieldOffset(Offset = "0x88")]
  public UnlockContainer unlockContainer;
  [Token(Token = "0x4000B27")]
  public static Action<UnlockContainer> A_Clicked;

  [Token(Token = "0x60009C5")]
  [Address(RVA = "0x4D7070", Offset = "0x4D5C70", Length = "0x5")]
  public override void StartHover()
  {
  }

  [Token(Token = "0x60009C6")]
  [Address(RVA = "0x4D7080", Offset = "0x4D5C80", Length = "0x5")]
  public override void StopHover()
  {
  }

  [Token(Token = "0x60009C7")]
  [Address(RVA = "0x4DAF20", Offset = "0x4D9B20", Length = "0x72")]
  protected override void OnClick()
  {
  }

  [Token(Token = "0x60009C8")]
  [Address(RVA = "0x4DAFA0", Offset = "0x4D9BA0", Length = "0x83")]
  private new void Update()
  {
  }

  [Token(Token = "0x60009C9")]
  [Address(RVA = "0x4D7090", Offset = "0x4D5C90", Length = "0xE")]
  public MyButtonUnlock()
  {
  }
}
