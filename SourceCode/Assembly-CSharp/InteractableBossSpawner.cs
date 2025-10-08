// Decompiled with JetBrains decompiler
// Type: InteractableBossSpawner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x200008E")]
public class InteractableBossSpawner : BaseInteractable
{
  [Token(Token = "0x4000486")]
  [FieldOffset(Offset = "0x58")]
  public GameObject minimapIcon;
  [Token(Token = "0x4000487")]
  [FieldOffset(Offset = "0x60")]
  private List<Enemy> bossEnemies;
  [Token(Token = "0x4000488")]
  public static Action A_BossSpawned;
  [Token(Token = "0x4000489")]
  public static Action<bool> A_BossDefeated;
  [Token(Token = "0x400048A")]
  [FieldOffset(Offset = "0x68")]
  public GameObject preventObjectsSpawningHere;
  [Token(Token = "0x400048B")]
  [FieldOffset(Offset = "0x70")]
  public GameObject portal;
  [Token(Token = "0x400048C")]
  [FieldOffset(Offset = "0x78")]
  public GameObject bossCurseFx;

  [Token(Token = "0x6000392")]
  [Address(RVA = "0x4767A0", Offset = "0x4753A0", Length = "0x246")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000393")]
  [Address(RVA = "0x476D90", Offset = "0x475990", Length = "0x246")]
  private new void OnDestroy()
  {
  }

  [Token(Token = "0x6000394")]
  [Address(RVA = "0x4772E0", Offset = "0x475EE0", Length = "0x20")]
  private new void Start()
  {
  }

  [Token(Token = "0x6000395")]
  [Address(RVA = "0x476FE0", Offset = "0x475BE0", Length = "0x258")]
  private void OnEnemyReleasedFromPool(Enemy enemy)
  {
  }

  [Token(Token = "0x6000396")]
  [Address(RVA = "0x4769F0", Offset = "0x4755F0", Length = "0xA8")]
  private bool CanSpawnPortal() => false;

  [Token(Token = "0x6000397")]
  [Address(RVA = "0x476AF0", Offset = "0x4756F0", Length = "0x29C")]
  public override bool Interact() => false;

  [Token(Token = "0x6000398")]
  [Address(RVA = "0x477240", Offset = "0x475E40", Length = "0x92")]
  private void OnInteractable(BaseInteractable interactable, bool success)
  {
  }

  [Token(Token = "0x6000399")]
  [Address(RVA = "0x476AA0", Offset = "0x4756A0", Length = "0x46")]
  public override string GetInteractString() => (string) null;

  [Token(Token = "0x600039A")]
  [Address(RVA = "0x475AC0", Offset = "0x4746C0", Length = "0xB")]
  public InteractableBossSpawner()
  {
  }
}
