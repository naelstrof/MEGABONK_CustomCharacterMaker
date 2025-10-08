// Decompiled with JetBrains decompiler
// Type: InteractableCageKey
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Items;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000A3")]
public class InteractableCageKey : BaseInteractable
{
  [Token(Token = "0x4000508")]
  [FieldOffset(Offset = "0x58")]
  public GameObject fx;
  [Token(Token = "0x4000509")]
  [FieldOffset(Offset = "0x60")]
  private bool done;
  [Token(Token = "0x400050A")]
  [FieldOffset(Offset = "0x64")]
  public EItem eItem;

  [Token(Token = "0x600040F")]
  [Address(RVA = "0x477380", Offset = "0x475F80", Length = "0x10D")]
  public override bool Interact() => false;

  [Token(Token = "0x6000410")]
  [Address(RVA = "0x477310", Offset = "0x475F10", Length = "0x6D")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x6000411")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableCageKey()
  {
  }
}
