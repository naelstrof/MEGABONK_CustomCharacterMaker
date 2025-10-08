// Decompiled with JetBrains decompiler
// Type: InteractableShrineBalance
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000099")]
public class InteractableShrineBalance : BaseInteractable
{
  [Token(Token = "0x40004CE")]
  [FieldOffset(Offset = "0x58")]
  public GameObject minimapIcon;
  [Token(Token = "0x40004CF")]
  [FieldOffset(Offset = "0x60")]
  public GameObject alertIcon;
  [Token(Token = "0x40004D0")]
  [FieldOffset(Offset = "0x68")]
  public bool done;

  [Token(Token = "0x60003E3")]
  [Address(RVA = "0x479A60", Offset = "0x478660", Length = "0xBD")]
  public override bool Interact() => false;

  [Token(Token = "0x60003E4")]
  [Address(RVA = "0x479A10", Offset = "0x478610", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003E5")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableShrineBalance()
  {
  }
}
