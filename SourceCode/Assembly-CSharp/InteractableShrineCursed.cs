// Decompiled with JetBrains decompiler
// Type: InteractableShrineCursed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200009B")]
public class InteractableShrineCursed : BaseInteractable
{
  [Token(Token = "0x40004D8")]
  [FieldOffset(Offset = "0x58")]
  public GameObject minimapIcon;
  [Token(Token = "0x40004D9")]
  [FieldOffset(Offset = "0x60")]
  public GameObject alertIcon;
  [Token(Token = "0x40004DA")]
  [FieldOffset(Offset = "0x68")]
  public bool done;
  [Token(Token = "0x40004DB")]
  [FieldOffset(Offset = "0x70")]
  public GameObject impactFx;
  [Token(Token = "0x40004DC")]
  [FieldOffset(Offset = "0x78")]
  public GameObject constantFx;

  [Token(Token = "0x60003ED")]
  [Address(RVA = "0x47A6D0", Offset = "0x4792D0", Length = "0xD9")]
  public override bool Interact() => false;

  [Token(Token = "0x60003EE")]
  [Address(RVA = "0x47A680", Offset = "0x479280", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003EF")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableShrineCursed()
  {
  }
}
