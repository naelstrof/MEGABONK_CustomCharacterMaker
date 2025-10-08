// Decompiled with JetBrains decompiler
// Type: InteractableShrineChallenge
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200009A")]
public class InteractableShrineChallenge : BaseInteractable
{
  [Token(Token = "0x40004D1")]
  [FieldOffset(Offset = "0x58")]
  public GameObject minimapIcon;
  [Token(Token = "0x40004D2")]
  [FieldOffset(Offset = "0x60")]
  public GameObject alertIcon;
  [Token(Token = "0x40004D3")]
  [FieldOffset(Offset = "0x68")]
  private bool done;
  [Token(Token = "0x40004D4")]
  [FieldOffset(Offset = "0x70")]
  public GameObject fx;
  [Token(Token = "0x40004D5")]
  [FieldOffset(Offset = "0x78")]
  private HashSet<Enemy> enemies;
  [Token(Token = "0x40004D6")]
  public static Action A_Completed;
  [Token(Token = "0x40004D7")]
  [FieldOffset(Offset = "0x80")]
  private bool hasGivenReward;

  [Token(Token = "0x60003E6")]
  [Address(RVA = "0x479B20", Offset = "0x478720", Length = "0x140")]
  private void Awake()
  {
  }

  [Token(Token = "0x60003E7")]
  [Address(RVA = "0x47A530", Offset = "0x479130", Length = "0x140")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x60003E8")]
  [Address(RVA = "0x479E80", Offset = "0x478A80", Length = "0x6A3")]
  public override bool Interact() => false;

  [Token(Token = "0x60003E9")]
  [Address(RVA = "0x476500", Offset = "0x475100", Length = "0x8")]
  public override bool CanInteract() => false;

  [Token(Token = "0x60003EA")]
  [Address(RVA = "0x479C70", Offset = "0x478870", Length = "0x1B0")]
  private void EnemyDied(Enemy enemy)
  {
  }

  [Token(Token = "0x60003EB")]
  [Address(RVA = "0x479E30", Offset = "0x478A30", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x60003EC")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableShrineChallenge()
  {
  }
}
