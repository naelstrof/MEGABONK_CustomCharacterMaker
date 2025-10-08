// Decompiled with JetBrains decompiler
// Type: ProjectileShotgun
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000CA")]
public class ProjectileShotgun : ProjectileBase
{
  [Token(Token = "0x4000686")]
  [FieldOffset(Offset = "0x68")]
  public ParticleSystem psBullets;
  [Token(Token = "0x4000687")]
  [FieldOffset(Offset = "0x70")]
  private ParticleSystem.EmissionModule psBulletsEmission;
  [Token(Token = "0x4000688")]
  [FieldOffset(Offset = "0x78")]
  public float testMultiplier;
  [Token(Token = "0x4000689")]
  [FieldOffset(Offset = "0x7C")]
  private float forwardOffset;
  [Token(Token = "0x400068A")]
  [FieldOffset(Offset = "0x80")]
  private float upOffset;
  [Token(Token = "0x400068B")]
  [FieldOffset(Offset = "0x84")]
  private Vector3 attackDir;

  [Token(Token = "0x600056A")]
  [Address(RVA = "0x4AC430", Offset = "0x4AB030", Length = "0x3C9")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x600056B")]
  [Address(RVA = "0x4AC170", Offset = "0x4AAD70", Length = "0x12C")]
  private Vector3 GetShootingPosition() => new Vector3();

  [Token(Token = "0x600056C")]
  [Address(RVA = "0x4AB980", Offset = "0x4AA580", Length = "0x793")]
  private Vector3 GetAttackDir() => new Vector3();

  [Token(Token = "0x600056D")]
  [Address(RVA = "0x4AC2A0", Offset = "0x4AAEA0", Length = "0x189")]
  private void SetBurstCount()
  {
  }

  [Token(Token = "0x600056E")]
  [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
  private float GetRange() => 0.0f;

  [Token(Token = "0x600056F")]
  [Address(RVA = "0x4AB2B0", Offset = "0x4A9EB0", Length = "0x6C3")]
  public void CheckZone(WeaponBase weaponBase)
  {
  }

  [Token(Token = "0x6000570")]
  [Address(RVA = "0x4AC120", Offset = "0x4AAD20", Length = "0x4A")]
  private int GetRawQuantity() => 0;

  [Token(Token = "0x6000571")]
  [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x6000572")]
  [Address(RVA = "0x3F3790", Offset = "0x3F2390", Length = "0x19")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x6000573")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x6000574")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x6000575")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x6000576")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x6000577")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000578")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x6000579")]
  [Address(RVA = "0x4AC800", Offset = "0x4AB400", Length = "0xE")]
  public ProjectileShotgun()
  {
  }
}
