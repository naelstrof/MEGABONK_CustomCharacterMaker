// Decompiled with JetBrains decompiler
// Type: EnemySpecialAttackTargetLaser
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Game.Combat.EnemySpecialAttacks.Implementations;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x2000064")]
public class EnemySpecialAttackTargetLaser : EnemySpecialAttackPrefab
{
  [Token(Token = "0x4000330")]
  [FieldOffset(Offset = "0x50")]
  public Transform laser;
  [Token(Token = "0x4000331")]
  [FieldOffset(Offset = "0x58")]
  public Transform laserEnd;
  [Token(Token = "0x4000332")]
  [FieldOffset(Offset = "0x60")]
  private float speed;
  [Token(Token = "0x4000333")]
  [FieldOffset(Offset = "0x64")]
  private float defaultMaxSpeed;
  [Token(Token = "0x4000334")]
  [FieldOffset(Offset = "0x68")]
  private float maxSpeed;
  [Token(Token = "0x4000335")]
  [FieldOffset(Offset = "0x70")]
  public Transform blackhole;
  [Token(Token = "0x4000336")]
  [FieldOffset(Offset = "0x78")]
  private float maxLaserLength;
  [Token(Token = "0x4000337")]
  [FieldOffset(Offset = "0x7C")]
  private float laserLength;
  [Token(Token = "0x4000338")]
  [FieldOffset(Offset = "0x80")]
  private float overAtTime;
  [Token(Token = "0x4000339")]
  [FieldOffset(Offset = "0x84")]
  private float timeToMaxSpeed;
  [Token(Token = "0x400033A")]
  [FieldOffset(Offset = "0x88")]
  private float speedTimer;
  [Token(Token = "0x400033B")]
  [FieldOffset(Offset = "0x8C")]
  private float damageCooldown;
  [Token(Token = "0x400033C")]
  [FieldOffset(Offset = "0x90")]
  private float nextDamageReadyTime;

  [Token(Token = "0x600028D")]
  [Address(RVA = "0x462500", Offset = "0x461100", Length = "0x53A")]
  protected override void Init()
  {
  }

  [Token(Token = "0x600028E")]
  [Address(RVA = "0x462400", Offset = "0x461000", Length = "0xF6")]
  private Vector3 GetLaserPosition() => new Vector3();

  [Token(Token = "0x600028F")]
  [Address(RVA = "0x462C10", Offset = "0x461810", Length = "0x17F")]
  private void Update()
  {
  }

  [Token(Token = "0x6000290")]
  [Address(RVA = "0x461AE0", Offset = "0x4606E0", Length = "0x91A")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x6000291")]
  [Address(RVA = "0x462A40", Offset = "0x461640", Length = "0x1CD")]
  private void OnTriggerStay(Collider other)
  {
  }

  [Token(Token = "0x6000292")]
  [Address(RVA = "0x462D90", Offset = "0x461990", Length = "0x30")]
  public EnemySpecialAttackTargetLaser()
  {
  }
}
