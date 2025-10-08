// Decompiled with JetBrains decompiler
// Type: ProjectileSniper
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000CB")]
public class ProjectileSniper : ProjectileBase
{
  [Token(Token = "0x400068C")]
  [FieldOffset(Offset = "0x68")]
  public Vector3 attackDir;
  [Token(Token = "0x400068D")]
  [FieldOffset(Offset = "0x74")]
  private float bulletSpeed;
  [Token(Token = "0x400068E")]
  [FieldOffset(Offset = "0x78")]
  private float maxDistance;
  [Token(Token = "0x400068F")]
  [FieldOffset(Offset = "0x7C")]
  private float distTravelled;
  [Token(Token = "0x4000690")]
  [FieldOffset(Offset = "0x80")]
  private RaycastHit hitRaycast;

  [Token(Token = "0x600057A")]
  [Address(RVA = "0x4AD780", Offset = "0x4AC380", Length = "0x31A")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x600057B")]
  [Address(RVA = "0x4ACEC0", Offset = "0x4ABAC0", Length = "0x12C")]
  private Vector3 GetShootingPosition() => new Vector3();

  [Token(Token = "0x600057C")]
  [Address(RVA = "0x4AC810", Offset = "0x4AB410", Length = "0x680")]
  private Vector3 GetAttackDir(int projectileIndex) => new Vector3();

  [Token(Token = "0x600057D")]
  [Address(RVA = "0x4ACEA0", Offset = "0x4ABAA0", Length = "0x13")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x600057E")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x600057F")]
  [Address(RVA = "0x4AD470", Offset = "0x4AC070", Length = "0x303")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x6000580")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x6000581")]
  [Address(RVA = "0x4ACFF0", Offset = "0x4ABBF0", Length = "0x476")]
  public void Hitscan(WeaponBase weaponBase, float radius)
  {
  }

  [Token(Token = "0x6000582")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x6000583")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000584")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x6000585")]
  [Address(RVA = "0x4ADAA0", Offset = "0x4AC6A0", Length = "0x59")]
  public ProjectileSniper()
  {
  }
}
