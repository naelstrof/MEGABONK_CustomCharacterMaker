// Decompiled with JetBrains decompiler
// Type: ProjectileFirefield
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000C1")]
public class ProjectileFirefield : ProjectileBase
{
  [Token(Token = "0x400065C")]
  [FieldOffset(Offset = "0x68")]
  private float spawnTime;
  [Token(Token = "0x400065D")]
  [FieldOffset(Offset = "0x6C")]
  private float aliveTime;
  [Token(Token = "0x400065E")]
  [FieldOffset(Offset = "0x70")]
  private float spawnRadius;
  [Token(Token = "0x400065F")]
  [FieldOffset(Offset = "0x74")]
  private Vector3 normal;
  [Token(Token = "0x4000660")]
  [FieldOffset(Offset = "0x80")]
  public Firefield firefield;
  [Token(Token = "0x4000661")]
  [FieldOffset(Offset = "0x88")]
  private string damageSource;

  [Token(Token = "0x6000512")]
  [Address(RVA = "0x4A5E50", Offset = "0x4A4A50", Length = "0x2A1")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x6000513")]
  [Address(RVA = "0x487D80", Offset = "0x486980", Length = "0x4A")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x6000514")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x6000515")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void CheckDamage()
  {
  }

  [Token(Token = "0x6000516")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x6000517")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x6000518")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000519")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x600051A")]
  [Address(RVA = "0x4A6100", Offset = "0x4A4D00", Length = "0x74")]
  public ProjectileFirefield()
  {
  }
}
