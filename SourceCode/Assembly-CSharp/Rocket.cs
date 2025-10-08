// Decompiled with JetBrains decompiler
// Type: Rocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x20000B6")]
public class Rocket : MonoBehaviour
{
  [Token(Token = "0x40005DF")]
  [FieldOffset(Offset = "0x20")]
  private float damage;
  [Token(Token = "0x40005E0")]
  [FieldOffset(Offset = "0x24")]
  private float spawnedAtTime;
  [Token(Token = "0x40005E1")]
  [FieldOffset(Offset = "0x28")]
  private float projectileSpeed;
  [Token(Token = "0x40005E2")]
  [FieldOffset(Offset = "0x2C")]
  public float projectileRadius;
  [Token(Token = "0x40005E3")]
  [FieldOffset(Offset = "0x30")]
  private float upTime;
  [Token(Token = "0x40005E4")]
  [FieldOffset(Offset = "0x34")]
  private float expirationTime;
  [Token(Token = "0x40005E5")]
  [FieldOffset(Offset = "0x38")]
  private WeaponBase weaponBase;
  [Token(Token = "0x40005E6")]
  [FieldOffset(Offset = "0x40")]
  private bool useGenericPool;
  [Token(Token = "0x40005E7")]
  [FieldOffset(Offset = "0x48")]
  private string damageSource;
  [Token(Token = "0x40005E8")]
  [FieldOffset(Offset = "0x50")]
  public Action A_ProjectileDone;
  [Token(Token = "0x40005E9")]
  [FieldOffset(Offset = "0x58")]
  private Vector3 startDirection;
  [Token(Token = "0x40005EA")]
  [FieldOffset(Offset = "0x64")]
  private Vector3 lastDirection;
  [Token(Token = "0x40005EB")]
  [FieldOffset(Offset = "0x70")]
  private Enemy targetEnemy;
  [Token(Token = "0x40005EC")]
  [FieldOffset(Offset = "0x78")]
  private Vector3 currentDir;
  [Token(Token = "0x40005ED")]
  [FieldOffset(Offset = "0x84")]
  private float nextFindTime;
  [Token(Token = "0x40005EE")]
  [FieldOffset(Offset = "0x88")]
  private float procCoefficient;
  [Token(Token = "0x40005EF")]
  [FieldOffset(Offset = "0x90")]
  private DamageContainer reuseDc;

  [Token(Token = "0x600049E")]
  [Address(RVA = "0x48DE80", Offset = "0x48CA80", Length = "0x2B4")]
  public void Set(
    Vector3 pos,
    float damage,
    float procCoefficient,
    WeaponBase weaponBase,
    bool useGenericPool,
    string damageSource)
  {
  }

  [Token(Token = "0x600049F")]
  [Address(RVA = "0x48D410", Offset = "0x48C010", Length = "0xEB")]
  private void FixedUpdate()
  {
  }

  [Token(Token = "0x60004A0")]
  [Address(RVA = "0x48D500", Offset = "0x48C100", Length = "0x420")]
  private Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x60004A1")]
  [Address(RVA = "0x48DE70", Offset = "0x48CA70", Length = "0xD")]
  public void SetTarget(Enemy targetEnemy)
  {
  }

  [Token(Token = "0x60004A2")]
  [Address(RVA = "0x48D2E0", Offset = "0x48BEE0", Length = "0x123")]
  private void FindTarget()
  {
  }

  [Token(Token = "0x60004A3")]
  [Address(RVA = "0x48E140", Offset = "0x48CD40", Length = "0x402")]
  protected virtual void StepMovement()
  {
  }

  [Token(Token = "0x60004A4")]
  [Address(RVA = "0x48D0E0", Offset = "0x48BCE0", Length = "0x162")]
  protected virtual void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x60004A5")]
  [Address(RVA = "0x48CFC0", Offset = "0x48BBC0", Length = "0x11B")]
  protected virtual bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x60004A6")]
  [Address(RVA = "0x48D930", Offset = "0x48C530", Length = "0x2CA")]
  private bool HitEnemy(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x60004A7")]
  [Address(RVA = "0x48DC00", Offset = "0x48C800", Length = "0x7")]
  private void HitOther(Collider collider, Vector3 normal)
  {
  }

  [Token(Token = "0x60004A8")]
  [Address(RVA = "0x48D250", Offset = "0x48BE50", Length = "0x8D")]
  private void CheckTimeout()
  {
  }

  [Token(Token = "0x60004A9")]
  [Address(RVA = "0x48DC10", Offset = "0x48C810", Length = "0x25C")]
  protected void ProjectileDone()
  {
  }

  [Token(Token = "0x60004AA")]
  [Address(RVA = "0x48E550", Offset = "0x48D150", Length = "0x8A")]
  public Rocket()
  {
  }
}
