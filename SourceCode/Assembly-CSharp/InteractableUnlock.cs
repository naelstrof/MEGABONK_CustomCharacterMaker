// Decompiled with JetBrains decompiler
// Type: InteractableUnlock
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using UnityEngine;
using UnityEngine.UI;

[Token(Token = "0x20000A4")]
public class InteractableUnlock : BaseInteractable
{
  [Token(Token = "0x400050B")]
  [FieldOffset(Offset = "0x58")]
  public UnlockableBase unlock;
  [Token(Token = "0x400050C")]
  [FieldOffset(Offset = "0x60")]
  public GameObject fx;
  [Token(Token = "0x400050D")]
  [FieldOffset(Offset = "0x68")]
  public RawImage icon;
  [Token(Token = "0x400050E")]
  [FieldOffset(Offset = "0x70")]
  private bool done;

  [Token(Token = "0x6000412")]
  [Address(RVA = "0x47BD90", Offset = "0x47A990", Length = "0x43")]
  private new void Start()
  {
  }

  [Token(Token = "0x6000413")]
  [Address(RVA = "0x47BA40", Offset = "0x47A640", Length = "0x348")]
  public override bool Interact() => false;

  [Token(Token = "0x6000414")]
  [Address(RVA = "0x47BA10", Offset = "0x47A610", Length = "0x2A")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x6000415")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableUnlock()
  {
  }
}
