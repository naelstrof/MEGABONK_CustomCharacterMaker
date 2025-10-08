// Decompiled with JetBrains decompiler
// Type: EnemySpecialAttackManyRandom
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations;
using Cpp2ILInjected;
using System.Collections;
using UnityEngine;

[Token(Token = "0x200005C")]
public class EnemySpecialAttackManyRandom : EnemySpecialAttackPrefab
{
  [Token(Token = "0x40002FE")]
  [FieldOffset(Offset = "0x50")]
  public bool grounded;
  [Token(Token = "0x40002FF")]
  [FieldOffset(Offset = "0x51")]
  public bool predictive;
  [Token(Token = "0x4000300")]
  [FieldOffset(Offset = "0x54")]
  public int circles;
  [Token(Token = "0x4000301")]
  [FieldOffset(Offset = "0x58")]
  private int numToSpawn;
  [Token(Token = "0x4000302")]
  [FieldOffset(Offset = "0x5C")]
  private int numSpawned;
  [Token(Token = "0x4000303")]
  [FieldOffset(Offset = "0x60")]
  public float delayBetweenCircles;
  [Token(Token = "0x4000304")]
  [FieldOffset(Offset = "0x64")]
  public float margin;

  [Token(Token = "0x600026D")]
  [Address(RVA = "0x35BB20", Offset = "0x35A720", Length = "0x79")]
  protected override void Init()
  {
  }

  [Token(Token = "0x600026E")]
  [Address(RVA = "0x35BAB0", Offset = "0x35A6B0", Length = "0x67")]
  private IEnumerator DoAttack() => (IEnumerator) null;

  [Token(Token = "0x600026F")]
  [Address(RVA = "0x35BBA0", Offset = "0x35A7A0", Length = "0x39F")]
  private void SpawnHitEffect(Vector3 pos)
  {
  }

  [Token(Token = "0x6000270")]
  [Address(RVA = "0x35BF40", Offset = "0x35AB40", Length = "0x20")]
  public EnemySpecialAttackManyRandom()
  {
  }
}
