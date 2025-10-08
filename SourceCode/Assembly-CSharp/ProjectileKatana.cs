// Decompiled with JetBrains decompiler
// Type: ProjectileKatana
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000C3")]
public class ProjectileKatana : ProjectileBase
{
  [Token(Token = "0x400066F")]
  [FieldOffset(Offset = "0x68")]
  public float testMultiplier;

  [Token(Token = "0x6000527")]
  [Address(RVA = "0x4A7A80", Offset = "0x4A6680", Length = "0x303")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x6000528")]
  [Address(RVA = "0x4A7780", Offset = "0x4A6380", Length = "0x2FF")]
  public void CheckZone(WeaponBase weaponBase, float radius, GameObject hitEffect = null)
  {
  }

  [Token(Token = "0x6000529")]
  [Address(RVA = "0x483E90", Offset = "0x482A90", Length = "0x47")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x600052A")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x600052B")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x600052C")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x600052D")]
  [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x600052E")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x600052F")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000530")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x6000531")]
  [Address(RVA = "0x4A7D90", Offset = "0x4A6990", Length = "0xE")]
  public ProjectileKatana()
  {
  }
}
