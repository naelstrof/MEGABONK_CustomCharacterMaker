// Decompiled with JetBrains decompiler
// Type: EnemySpecialAttackPrefabMulti
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations;
using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

[Token(Token = "0x2000060")]
public class EnemySpecialAttackPrefabMulti : EnemySpecialAttackPrefab
{
  [Token(Token = "0x400030F")]
  [FieldOffset(Offset = "0x50")]
  public bool grounded;
  [Token(Token = "0x4000310")]
  [FieldOffset(Offset = "0x54")]
  public int numLines;
  [Token(Token = "0x4000311")]
  [FieldOffset(Offset = "0x58")]
  public int degreesBetweenLines;
  [Token(Token = "0x4000312")]
  [FieldOffset(Offset = "0x5C")]
  public int numHits;
  [Token(Token = "0x4000313")]
  [FieldOffset(Offset = "0x60")]
  public float hitsSpacingMultiplier;
  [Token(Token = "0x4000314")]
  [FieldOffset(Offset = "0x64")]
  public float delayBetweenHits;
  [Token(Token = "0x4000315")]
  [FieldOffset(Offset = "0x68")]
  private int numSpawned;

  [Token(Token = "0x600027B")]
  [Address(RVA = "0x460280", Offset = "0x45EE80", Length = "0x135")]
  protected override void Init()
  {
  }

  [Token(Token = "0x600027C")]
  [Address(RVA = "0x460210", Offset = "0x45EE10", Length = "0x67")]
  private IEnumerator DoAttack() => (IEnumerator) null;

  [Token(Token = "0x600027D")]
  [Address(RVA = "0x4603C0", Offset = "0x45EFC0", Length = "0x34B")]
  private void SpawnHitEffect(Vector3 pos)
  {
  }

  [Token(Token = "0x600027E")]
  [Address(RVA = "0x460710", Offset = "0x45F310", Length = "0x2E")]
  public EnemySpecialAttackPrefabMulti()
  {
  }
}
