// Decompiled with JetBrains decompiler
// Type: ProjectileBanana
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000B9")]
public class ProjectileBanana : ProjectileBase
{
  [Token(Token = "0x4000605")]
  [FieldOffset(Offset = "0x68")]
  public Transform renderer;
  [Token(Token = "0x4000606")]
  [FieldOffset(Offset = "0x70")]
  public TrailRenderer trailRenderer;
  [Token(Token = "0x4000607")]
  [FieldOffset(Offset = "0x78")]
  private float trailStartWidth;
  [Token(Token = "0x4000608")]
  [FieldOffset(Offset = "0x7C")]
  private Vector3 startDirection;
  [Token(Token = "0x4000609")]
  [FieldOffset(Offset = "0x88")]
  private Vector3 movementVelocity;
  [Token(Token = "0x400060A")]
  [FieldOffset(Offset = "0x98")]
  private Dictionary<Collider, float> enemyHitCooldowns;
  [Token(Token = "0x400060B")]
  [FieldOffset(Offset = "0xA0")]
  private float hitCooldown;
  [Token(Token = "0x400060C")]
  [FieldOffset(Offset = "0xA4")]
  private float readyToCollectTime;
  [Token(Token = "0x400060D")]
  [FieldOffset(Offset = "0xA8")]
  private float sqrCollectDistance;
  [Token(Token = "0x400060E")]
  [FieldOffset(Offset = "0xAC")]
  private float maxSpeed;
  [Token(Token = "0x400060F")]
  [FieldOffset(Offset = "0xB0")]
  private float returnTime;
  [Token(Token = "0x4000610")]
  [FieldOffset(Offset = "0xB4")]
  private Vector3 dirToPlayer;
  [Token(Token = "0x4000611")]
  [FieldOffset(Offset = "0xC0")]
  public Rigidbody rb;
  [Token(Token = "0x4000612")]
  [FieldOffset(Offset = "0xC8")]
  private float nextCheckDamageTime;
  [Token(Token = "0x4000613")]
  [FieldOffset(Offset = "0xCC")]
  private float distToPlayer;
  [Token(Token = "0x4000614")]
  [FieldOffset(Offset = "0xD0")]
  private bool isCloseToPlayer;

  [Token(Token = "0x60004C2")]
  [Address(RVA = "0x4865B0", Offset = "0x4851B0", Length = "0x426")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x60004C3")]
  [Address(RVA = "0x485840", Offset = "0x484440", Length = "0x19")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x60004C4")]
  [Address(RVA = "0x485C10", Offset = "0x484810", Length = "0x4F8")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x60004C5")]
  [Address(RVA = "0x4861B0", Offset = "0x484DB0", Length = "0x3F4")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x60004C6")]
  [Address(RVA = "0x485B90", Offset = "0x484790", Length = "0x80")]
  private bool IsUsingSphereCast() => false;

  [Token(Token = "0x60004C7")]
  [Address(RVA = "0x4856B0", Offset = "0x4842B0", Length = "0x18C")]
  private void CheckRadiusDamage()
  {
  }

  [Token(Token = "0x60004C8")]
  [Address(RVA = "0x485550", Offset = "0x484150", Length = "0x159")]
  private void CheckHitPlayer()
  {
  }

  [Token(Token = "0x60004C9")]
  [Address(RVA = "0x4854B0", Offset = "0x4840B0", Length = "0x92")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x60004CA")]
  [Address(RVA = "0x485860", Offset = "0x484460", Length = "0x322")]
  private bool HitEnemy(Collider collider) => false;

  [Token(Token = "0x60004CB")]
  [Address(RVA = "0x486110", Offset = "0x484D10", Length = "0x97")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x60004CC")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x60004CD")]
  [Address(RVA = "0x4869E0", Offset = "0x4855E0", Length = "0x87")]
  public ProjectileBanana()
  {
  }
}
