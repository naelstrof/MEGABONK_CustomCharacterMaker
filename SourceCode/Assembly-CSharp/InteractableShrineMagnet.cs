// Decompiled with JetBrains decompiler
// Type: InteractableShrineMagnet
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200009D")]
public class InteractableShrineMagnet : BaseInteractable
{
  [Token(Token = "0x40004E5")]
  [FieldOffset(Offset = "0x58")]
  public GameObject minimapIcon;
  [Token(Token = "0x40004E6")]
  [FieldOffset(Offset = "0x60")]
  public GameObject shrineIcon;
  [Token(Token = "0x40004E7")]
  [FieldOffset(Offset = "0x68")]
  private bool done;
  [Token(Token = "0x40004E8")]
  [FieldOffset(Offset = "0x70")]
  public GameObject interactFx;

  [Token(Token = "0x60003F4")]
  [Address(RVA = "0x47AA10", Offset = "0x479610", Length = "0xE3")]
  public override bool Interact() => false;

  [Token(Token = "0x60003F5")]
  [Address(RVA = "0x47A9C0", Offset = "0x4795C0", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003F6")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableShrineMagnet()
  {
  }
}
