// Decompiled with JetBrains decompiler
// Type: ProjectileHeroSword
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000C2")]
public class ProjectileHeroSword : ProjectileBase
{
  [Token(Token = "0x4000662")]
  [FieldOffset(Offset = "0x68")]
  public GameObject movingProjectile;
  [Token(Token = "0x4000663")]
  [FieldOffset(Offset = "0x70")]
  private Vector3 movingProjectileDir;
  [Token(Token = "0x4000664")]
  [FieldOffset(Offset = "0x7C")]
  private Vector3 hitboxPos;
  [Token(Token = "0x4000665")]
  [FieldOffset(Offset = "0x88")]
  private Quaternion movingProjectileRotation;
  [Token(Token = "0x4000666")]
  [FieldOffset(Offset = "0x98")]
  private float movingProjectileDuration;
  [Token(Token = "0x4000667")]
  [FieldOffset(Offset = "0x9C")]
  private float startTime;
  [Token(Token = "0x4000668")]
  [FieldOffset(Offset = "0xA0")]
  public Vector3 colliderOffset;
  [Token(Token = "0x4000669")]
  [FieldOffset(Offset = "0xAC")]
  public float testMultiplier;
  [Token(Token = "0x400066A")]
  [FieldOffset(Offset = "0xB0")]
  private float forwardOffset;
  [Token(Token = "0x400066B")]
  [FieldOffset(Offset = "0xB4")]
  private float upOffset;
  [Token(Token = "0x400066C")]
  [FieldOffset(Offset = "0xB8")]
  private Vector3 posOffset;
  [Token(Token = "0x400066D")]
  [FieldOffset(Offset = "0xC8")]
  private new HashSet<Collider> hitEnemies;
  [Token(Token = "0x400066E")]
  [FieldOffset(Offset = "0xD0")]
  private Vector3 movingProjectilePosition;

  [Token(Token = "0x600051B")]
  [Address(RVA = "0x4A6E50", Offset = "0x4A5A50", Length = "0x861")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x600051C")]
  [Address(RVA = "0x483E90", Offset = "0x482A90", Length = "0x47")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x600051D")]
  [Address(RVA = "0x4A6810", Offset = "0x4A5410", Length = "0x3B1")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x600051E")]
  [Address(RVA = "0x4A6BD0", Offset = "0x4A57D0", Length = "0x277")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x600051F")]
  [Address(RVA = "0x4A64E0", Offset = "0x4A50E0", Length = "0x328")]
  public void CheckZone(WeaponBase weaponBase, float radius, GameObject hitEffect = null)
  {
  }

  [Token(Token = "0x6000520")]
  [Address(RVA = "0x4A6180", Offset = "0x4A4D80", Length = "0x35E")]
  private void CheckColliderCustom(Collider collider, float damageMultiplier)
  {
  }

  [Token(Token = "0x6000521")]
  [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x6000522")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000523")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x6000524")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x6000525")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x6000526")]
  [Address(RVA = "0x4A76C0", Offset = "0x4A62C0", Length = "0xB2")]
  public ProjectileHeroSword()
  {
  }
}
