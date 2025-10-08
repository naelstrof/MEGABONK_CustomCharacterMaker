// Decompiled with JetBrains decompiler
// Type: ProjectileMelee
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000C5")]
public class ProjectileMelee : ProjectileBase
{
  [Token(Token = "0x4000670")]
  [FieldOffset(Offset = "0x68")]
  public Vector3 colliderOffset;
  [Token(Token = "0x4000671")]
  [FieldOffset(Offset = "0x74")]
  public float testMultiplier;
  [Token(Token = "0x4000672")]
  [FieldOffset(Offset = "0x78")]
  private float forwardOffset;
  [Token(Token = "0x4000673")]
  [FieldOffset(Offset = "0x7C")]
  private float upOffset;
  [Token(Token = "0x4000674")]
  [FieldOffset(Offset = "0x80")]
  private List<ProjectileMelee.MeleeHit> effectHits;
  [Token(Token = "0x4000675")]
  [FieldOffset(Offset = "0x88")]
  private bool useAudio;

  [Token(Token = "0x6000539")]
  [Address(RVA = "0x4A8B30", Offset = "0x4A7730", Length = "0x325")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x600053A")]
  [Address(RVA = "0x483E90", Offset = "0x482A90", Length = "0x47")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x600053B")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x600053C")]
  [Address(RVA = "0x4A8720", Offset = "0x4A7320", Length = "0x286")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x600053D")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x600053E")]
  [Address(RVA = "0x4A8060", Offset = "0x4A6C60", Length = "0x6B4")]
  public void CheckZone(WeaponBase weaponBase, float radius, GameObject hitEffect = null)
  {
  }

  [Token(Token = "0x600053F")]
  [Address(RVA = "0x4A89B0", Offset = "0x4A75B0", Length = "0x17F")]
  private void SpawnEffect()
  {
  }

  [Token(Token = "0x6000540")]
  [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x6000541")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x6000542")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000543")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x6000544")]
  [Address(RVA = "0x4A8E60", Offset = "0x4A7A60", Length = "0xA6")]
  public ProjectileMelee()
  {
  }

  [Token(Token = "0x20000C6")]
  public class MeleeHit
  {
    [Token(Token = "0x4000676")]
    [FieldOffset(Offset = "0x10")]
    public Vector3 pos;
    [Token(Token = "0x4000677")]
    [FieldOffset(Offset = "0x1C")]
    public Vector3 dir;

    [Token(Token = "0x6000545")]
    [Address(RVA = "0x3E8570", Offset = "0x3E7170", Length = "0x4D")]
    public MeleeHit(Vector3 pos, Vector3 dir)
    {
    }
  }
}
