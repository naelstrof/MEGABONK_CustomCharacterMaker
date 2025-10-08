// Decompiled with JetBrains decompiler
// Type: InteractableBoombox
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

[Token(Token = "0x20000A1")]
public class InteractableBoombox : BaseInteractable
{
  [Token(Token = "0x40004FA")]
  [FieldOffset(Offset = "0x58")]
  public LocalizedString interactString;
  [Token(Token = "0x40004FB")]
  [FieldOffset(Offset = "0x60")]
  public GameObject alertIcon;
  [Token(Token = "0x40004FC")]
  [FieldOffset(Offset = "0x68")]
  private bool done;
  [Token(Token = "0x40004FD")]
  [FieldOffset(Offset = "0x70")]
  public GameObject fx;
  [Token(Token = "0x40004FE")]
  [FieldOffset(Offset = "0x78")]
  public AudioSource music;
  [Token(Token = "0x40004FF")]
  [FieldOffset(Offset = "0x80")]
  public Animator animator;
  [Token(Token = "0x4000500")]
  [FieldOffset(Offset = "0x88")]
  public MusicPauseZone pauseZone;

  [Token(Token = "0x6000406")]
  [Address(RVA = "0x476530", Offset = "0x475130", Length = "0xD9")]
  public override bool Interact() => false;

  [Token(Token = "0x6000407")]
  [Address(RVA = "0x476500", Offset = "0x475100", Length = "0x8")]
  public override bool CanInteract() => false;

  [Token(Token = "0x6000408")]
  [Address(RVA = "0x476510", Offset = "0x475110", Length = "0x1D")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x6000409")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableBoombox()
  {
  }
}
