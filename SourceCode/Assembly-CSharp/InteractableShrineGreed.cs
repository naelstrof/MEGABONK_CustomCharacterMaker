// Decompiled with JetBrains decompiler
// Type: InteractableShrineGreed
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.UI.InGame.Rewards;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.Localization;

[Token(Token = "0x200009C")]
public class InteractableShrineGreed : BaseInteractable
{
  [Token(Token = "0x40004DD")]
  [FieldOffset(Offset = "0x58")]
  public LocalizedString localizationName;
  [Token(Token = "0x40004DE")]
  [FieldOffset(Offset = "0x60")]
  public GameObject minimapIcon;
  [Token(Token = "0x40004DF")]
  [FieldOffset(Offset = "0x68")]
  public GameObject alertIcon;
  [Token(Token = "0x40004E0")]
  [FieldOffset(Offset = "0x70")]
  private bool done;
  [Token(Token = "0x40004E1")]
  [FieldOffset(Offset = "0x78")]
  public GameObject fx;
  [Token(Token = "0x40004E2")]
  [FieldOffset(Offset = "0x80")]
  public GameObject fxLoop;
  [Token(Token = "0x40004E3")]
  [FieldOffset(Offset = "0x88")]
  public EffectStat statEffect;
  [Token(Token = "0x40004E4")]
  [FieldOffset(Offset = "0x90")]
  public float goldRatio;

  [Token(Token = "0x60003F0")]
  [Address(RVA = "0x47A7C0", Offset = "0x4793C0", Length = "0x1FE")]
  public override bool Interact() => false;

  [Token(Token = "0x60003F1")]
  [Address(RVA = "0x47A7B0", Offset = "0x4793B0", Length = "0x8")]
  public override bool CanInteract() => false;

  [Token(Token = "0x60003F2")]
  [Address(RVA = "0x476510", Offset = "0x475110", Length = "0x1D")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003F3")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableShrineGreed()
  {
  }
}
