// Decompiled with JetBrains decompiler
// Type: InteractableBananarang
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000A0")]
public class InteractableBananarang : BaseInteractable
{
  [Token(Token = "0x40004F8")]
  [FieldOffset(Offset = "0x58")]
  public GameObject fx;
  [Token(Token = "0x40004F9")]
  [FieldOffset(Offset = "0x60")]
  private bool done;

  [Token(Token = "0x6000403")]
  [Address(RVA = "0x476370", Offset = "0x474F70", Length = "0x18E")]
  public override bool Interact() => false;

  [Token(Token = "0x6000404")]
  [Address(RVA = "0x476320", Offset = "0x474F20", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x6000405")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableBananarang()
  {
  }
}
