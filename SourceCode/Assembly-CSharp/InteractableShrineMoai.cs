// Decompiled with JetBrains decompiler
// Type: InteractableShrineMoai
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x200009E")]
public class InteractableShrineMoai : BaseInteractable
{
  [Token(Token = "0x40004E9")]
  [FieldOffset(Offset = "0x58")]
  public GameObject minimapIcon;
  [Token(Token = "0x40004EA")]
  [FieldOffset(Offset = "0x60")]
  public GameObject alertIcon;
  [Token(Token = "0x40004EB")]
  [FieldOffset(Offset = "0x68")]
  public bool done;

  [Token(Token = "0x60003F7")]
  [Address(RVA = "0x47AB50", Offset = "0x479750", Length = "0xBD")]
  public override bool Interact() => false;

  [Token(Token = "0x60003F8")]
  [Address(RVA = "0x47AB00", Offset = "0x479700", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003F9")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableShrineMoai()
  {
  }
}
