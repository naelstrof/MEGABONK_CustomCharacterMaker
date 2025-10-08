// Decompiled with JetBrains decompiler
// Type: EnemySpecialAttackHitscanMultiple
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations;
using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

[Token(Token = "0x2000059")]
public class EnemySpecialAttackHitscanMultiple : EnemySpecialAttackPrefab
{
  [Token(Token = "0x40002F1")]
  [FieldOffset(Offset = "0x50")]
  public float delayBetweenAttacks;
  [Token(Token = "0x40002F2")]
  [FieldOffset(Offset = "0x54")]
  public int numToSpawn;
  [Token(Token = "0x40002F3")]
  [FieldOffset(Offset = "0x58")]
  private int numSpawned;
  [Token(Token = "0x40002F4")]
  [FieldOffset(Offset = "0x5C")]
  public float maxRange;
  [Token(Token = "0x40002F5")]
  [FieldOffset(Offset = "0x60")]
  public Vector3 attackOffset;
  [Token(Token = "0x40002F6")]
  [FieldOffset(Offset = "0x6C")]
  public float randomPositionRadius;

  [Token(Token = "0x6000261")]
  [Address(RVA = "0x35B680", Offset = "0x35A280", Length = "0x78")]
  protected override void Init()
  {
  }

  [Token(Token = "0x6000262")]
  [Address(RVA = "0x35B610", Offset = "0x35A210", Length = "0x67")]
  private IEnumerator DoAttack() => (IEnumerator) null;

  [Token(Token = "0x6000263")]
  [Address(RVA = "0x35B700", Offset = "0x35A300", Length = "0x37D")]
  private void SpawnHitEffect(Vector3 pos, Vector3 dir)
  {
  }

  [Token(Token = "0x6000264")]
  [Address(RVA = "0x35BA80", Offset = "0x35A680", Length = "0x23")]
  public EnemySpecialAttackHitscanMultiple()
  {
  }
}
