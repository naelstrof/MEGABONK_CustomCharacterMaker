// Decompiled with JetBrains decompiler
// Type: ProjectileMines
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000C7")]
public class ProjectileMines : ProjectileBase
{
  [Token(Token = "0x4000678")]
  [FieldOffset(Offset = "0x68")]
  public Rigidbody rb;
  [Token(Token = "0x4000679")]
  [FieldOffset(Offset = "0x70")]
  private float checkInterval;
  [Token(Token = "0x400067A")]
  [FieldOffset(Offset = "0x74")]
  private float nextCheckTime;
  [Token(Token = "0x400067B")]
  [FieldOffset(Offset = "0x78")]
  private float checkRadius;
  [Token(Token = "0x400067C")]
  [FieldOffset(Offset = "0x7C")]
  private float scaleInTime;
  [Token(Token = "0x400067D")]
  [FieldOffset(Offset = "0x80")]
  private float spawnedAtTime;
  [Token(Token = "0x400067E")]
  [FieldOffset(Offset = "0x84")]
  private float scaleMultiplier;

  [Token(Token = "0x6000546")]
  [Address(RVA = "0x4A9770", Offset = "0x4A8370", Length = "0x1B9")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x6000547")]
  [Address(RVA = "0x4A9930", Offset = "0x4A8530", Length = "0x25F")]
  private void Update()
  {
  }

  [Token(Token = "0x6000548")]
  [Address(RVA = "0x4A9550", Offset = "0x4A8150", Length = "0x216")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x6000549")]
  [Address(RVA = "0x4A8F10", Offset = "0x4A7B10", Length = "0xE5")]
  private void CheckCollisions(Collider[] colliders)
  {
  }

  [Token(Token = "0x600054A")]
  [Address(RVA = "0x4A9000", Offset = "0x4A7C00", Length = "0x542")]
  private void Explode()
  {
  }

  [Token(Token = "0x600054B")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void Timeout()
  {
  }

  [Token(Token = "0x600054C")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x600054D")]
  [Address(RVA = "0x487D80", Offset = "0x486980", Length = "0x4A")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x600054E")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x600054F")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x6000550")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000551")]
  [Address(RVA = "0x4A9B90", Offset = "0x4A8790", Length = "0x1C")]
  public ProjectileMines()
  {
  }
}
