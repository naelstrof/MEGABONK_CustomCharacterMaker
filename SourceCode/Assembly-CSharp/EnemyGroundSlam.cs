// Decompiled with JetBrains decompiler
// Type: EnemyGroundSlam
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000057")]
public class EnemyGroundSlam : EnemySpecialAttackPrefab
{
  [Token(Token = "0x40002E7")]
  [FieldOffset(Offset = "0x50")]
  public GameObject hitEffect;
  [Token(Token = "0x40002E8")]
  [FieldOffset(Offset = "0x58")]
  public AudioSource hitSfx;
  [Token(Token = "0x40002E9")]
  [FieldOffset(Offset = "0x60")]
  private float finalRadius;

  [Token(Token = "0x600025A")]
  [Address(RVA = "0x35A6C0", Offset = "0x3592C0", Length = "0x320")]
  protected override void Init()
  {
  }

  [Token(Token = "0x600025B")]
  [Address(RVA = "0x35A9F0", Offset = "0x3595F0", Length = "0x30E")]
  private void SpawnHitEffect()
  {
  }

  [Token(Token = "0x600025C")]
  [Address(RVA = "0x357E60", Offset = "0x356A60", Length = "0x7")]
  public EnemyGroundSlam()
  {
  }
}
