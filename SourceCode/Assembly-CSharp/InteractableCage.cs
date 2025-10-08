// Decompiled with JetBrains decompiler
// Type: InteractableCage
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

[Token(Token = "0x20000A2")]
public class InteractableCage : BaseInteractable
{
  [Token(Token = "0x4000501")]
  [FieldOffset(Offset = "0x58")]
  public GameObject fx;
  [Token(Token = "0x4000502")]
  [FieldOffset(Offset = "0x60")]
  private bool done;
  [Token(Token = "0x4000503")]
  [FieldOffset(Offset = "0x68")]
  public AudioSource audioSource;
  [Token(Token = "0x4000504")]
  [FieldOffset(Offset = "0x70")]
  public GameObject monke;
  [Token(Token = "0x4000505")]
  [FieldOffset(Offset = "0x78")]
  public LocalizedString localizedString;
  [Token(Token = "0x4000506")]
  [FieldOffset(Offset = "0x80")]
  public MeshRenderer meshRenderer;
  [Token(Token = "0x4000507")]
  [FieldOffset(Offset = "0x88")]
  public BoxCollider collider;

  [Token(Token = "0x600040A")]
  [Address(RVA = "0x477530", Offset = "0x476130", Length = "0x11E")]
  public override bool Interact() => false;

  [Token(Token = "0x600040B")]
  [Address(RVA = "0x477490", Offset = "0x476090", Length = "0x7F")]
  public override bool CanInteract() => false;

  [Token(Token = "0x600040C")]
  [Address(RVA = "0x477510", Offset = "0x476110", Length = "0x1D")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x600040D")]
  [Address(RVA = "0x477490", Offset = "0x476090", Length = "0x7F")]
  private bool HasKey() => false;

  [Token(Token = "0x600040E")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableCage()
  {
  }
}
