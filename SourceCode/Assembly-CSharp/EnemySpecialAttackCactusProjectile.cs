// Decompiled with JetBrains decompiler
// Type: EnemySpecialAttackCactusProjectile
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000058")]
public class EnemySpecialAttackCactusProjectile : EnemySpecialAttackPrefab
{
  [Token(Token = "0x40002EA")]
  [FieldOffset(Offset = "0x50")]
  public bool grounded;
  [Token(Token = "0x40002EB")]
  [FieldOffset(Offset = "0x51")]
  public bool predictive;
  [Token(Token = "0x40002EC")]
  [FieldOffset(Offset = "0x54")]
  private float timer;
  [Token(Token = "0x40002ED")]
  [FieldOffset(Offset = "0x58")]
  private Vector3 impactPos;
  [Token(Token = "0x40002EE")]
  [FieldOffset(Offset = "0x64")]
  private Vector3 startPos;
  [Token(Token = "0x40002EF")]
  [FieldOffset(Offset = "0x70")]
  public TrailRenderer trailRenderer;
  [Token(Token = "0x40002F0")]
  [FieldOffset(Offset = "0x78")]
  private float arcHeight;

  [Token(Token = "0x600025D")]
  [Address(RVA = "0x35AD00", Offset = "0x359900", Length = "0x4A6")]
  protected override void Init()
  {
  }

  [Token(Token = "0x600025E")]
  [Address(RVA = "0x35B3D0", Offset = "0x359FD0", Length = "0x221")]
  private void Update()
  {
  }

  [Token(Token = "0x600025F")]
  [Address(RVA = "0x35B1B0", Offset = "0x359DB0", Length = "0x217")]
  private void SpawnHitEffect()
  {
  }

  [Token(Token = "0x6000260")]
  [Address(RVA = "0x35B600", Offset = "0x35A200", Length = "0xE")]
  public EnemySpecialAttackCactusProjectile()
  {
  }
}
