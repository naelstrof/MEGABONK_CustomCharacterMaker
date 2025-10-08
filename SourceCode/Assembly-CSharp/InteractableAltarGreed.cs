// Decompiled with JetBrains decompiler
// Type: InteractableAltarGreed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200008D")]
public class InteractableAltarGreed : BaseInteractable
{
  [Token(Token = "0x4000484")]
  [FieldOffset(Offset = "0x58")]
  public GameObject minimapIcon;
  [Token(Token = "0x4000485")]
  [FieldOffset(Offset = "0x60")]
  private bool done;

  [Token(Token = "0x600038F")]
  [Address(RVA = "0x476260", Offset = "0x474E60", Length = "0xB2")]
  public override bool Interact() => false;

  [Token(Token = "0x6000390")]
  [Address(RVA = "0x476230", Offset = "0x474E30", Length = "0x2C")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x6000391")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableAltarGreed()
  {
  }
}
