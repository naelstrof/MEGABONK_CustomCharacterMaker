// Decompiled with JetBrains decompiler
// Type: ProjectileCringeSword
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000BD")]
public class ProjectileCringeSword : ProjectileBase
{
  [Token(Token = "0x4000626")]
  [FieldOffset(Offset = "0x68")]
  public GameObject movingProjectile;
  [Token(Token = "0x4000627")]
  [FieldOffset(Offset = "0x70")]
  private Vector3 movingProjectileDir;
  [Token(Token = "0x4000628")]
  [FieldOffset(Offset = "0x7C")]
  private Vector3 hitboxPos;
  [Token(Token = "0x4000629")]
  [FieldOffset(Offset = "0x88")]
  private Quaternion movingProjectileRotation;
  [Token(Token = "0x400062A")]
  [FieldOffset(Offset = "0x98")]
  private float movingProjectileDuration;
  [Token(Token = "0x400062B")]
  [FieldOffset(Offset = "0x9C")]
  private float startTime;
  [Token(Token = "0x400062C")]
  [FieldOffset(Offset = "0xA0")]
  public Vector3 colliderOffset;
  [Token(Token = "0x400062D")]
  [FieldOffset(Offset = "0xAC")]
  public float testMultiplier;
  [Token(Token = "0x400062E")]
  [FieldOffset(Offset = "0xB0")]
  private float forwardOffset;
  [Token(Token = "0x400062F")]
  [FieldOffset(Offset = "0xB4")]
  private float upOffset;
  [Token(Token = "0x4000630")]
  [FieldOffset(Offset = "0xB8")]
  private Vector3 posOffset;
  [Token(Token = "0x4000631")]
  [FieldOffset(Offset = "0xC8")]
  private new HashSet<Collider> hitEnemies;
  [Token(Token = "0x4000632")]
  [FieldOffset(Offset = "0xD0")]
  private Vector3 movingProjectilePosition;

  [Token(Token = "0x60004EF")]
  [Address(RVA = "0x48A190", Offset = "0x488D90", Length = "0x7F6")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x60004F0")]
  [Address(RVA = "0x483E90", Offset = "0x482A90", Length = "0x47")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x60004F1")]
  [Address(RVA = "0x489B50", Offset = "0x488750", Length = "0x3B1")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x60004F2")]
  [Address(RVA = "0x489F10", Offset = "0x488B10", Length = "0x277")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x60004F3")]
  [Address(RVA = "0x489820", Offset = "0x488420", Length = "0x328")]
  public void CheckZone(WeaponBase weaponBase, float radius, GameObject hitEffect = null)
  {
  }

  [Token(Token = "0x60004F4")]
  [Address(RVA = "0x489370", Offset = "0x487F70", Length = "0x4A4")]
  private void CheckColliderCustom(Collider collider, float damageMultiplier)
  {
  }

  [Token(Token = "0x60004F5")]
  [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x60004F6")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x60004F7")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x60004F8")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x60004F9")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x60004FA")]
  [Address(RVA = "0x48A990", Offset = "0x489590", Length = "0xB2")]
  public ProjectileCringeSword()
  {
  }
}
