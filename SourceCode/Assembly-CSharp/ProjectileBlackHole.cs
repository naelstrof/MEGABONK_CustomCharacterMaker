// Decompiled with JetBrains decompiler
// Type: ProjectileBlackHole
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000BA")]
public class ProjectileBlackHole : ProjectileBase
{
  [Token(Token = "0x4000615")]
  [FieldOffset(Offset = "0x68")]
  public float collisionCooldown;
  [Token(Token = "0x4000616")]
  [FieldOffset(Offset = "0x6C")]
  private float forwardOffset;
  [Token(Token = "0x4000617")]
  [FieldOffset(Offset = "0x70")]
  private float upOffset;
  [Token(Token = "0x4000618")]
  [FieldOffset(Offset = "0x74")]
  private Vector3 pushDir;
  [Token(Token = "0x4000619")]
  [FieldOffset(Offset = "0x80")]
  private Vector3 defaultSize;
  [Token(Token = "0x400061A")]
  [FieldOffset(Offset = "0x8C")]
  private float startFadeTime;
  [Token(Token = "0x400061B")]
  [FieldOffset(Offset = "0x90")]
  private float maxSize;
  [Token(Token = "0x400061C")]
  [FieldOffset(Offset = "0x94")]
  private Vector3 desiredPosition;
  [Token(Token = "0x400061D")]
  [FieldOffset(Offset = "0xA0")]
  private Vector3 startPosition;
  [Token(Token = "0x400061E")]
  [FieldOffset(Offset = "0xAC")]
  private float moveTime;
  [Token(Token = "0x400061F")]
  [FieldOffset(Offset = "0xB0")]
  private float nextCheckDamageTime;
  [Token(Token = "0x4000620")]
  [FieldOffset(Offset = "0xB8")]
  private HashSet<Enemy> suckedEnemies;
  [Token(Token = "0x4000621")]
  [FieldOffset(Offset = "0xC0")]
  private float moveTimer;
  [Token(Token = "0x4000622")]
  [FieldOffset(Offset = "0xC4")]
  private Vector3 startScaleSize;

  [Token(Token = "0x60004CE")]
  [Address(RVA = "0x4875E0", Offset = "0x4861E0", Length = "0x6F4")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x60004CF")]
  [Address(RVA = "0x483E90", Offset = "0x482A90", Length = "0x47")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x60004D0")]
  [Address(RVA = "0x487060", Offset = "0x485C60", Length = "0x7")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x60004D1")]
  [Address(RVA = "0x486A70", Offset = "0x485670", Length = "0x5EC")]
  private void CheckDamage()
  {
  }

  [Token(Token = "0x60004D2")]
  [Address(RVA = "0x487450", Offset = "0x486050", Length = "0x18A")]
  private void OnDisable()
  {
  }

  [Token(Token = "0x60004D3")]
  [Address(RVA = "0x487070", Offset = "0x485C70", Length = "0x3D9")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x60004D4")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x60004D5")]
  [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x60004D6")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x60004D7")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x60004D8")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x60004D9")]
  [Address(RVA = "0x483F20", Offset = "0x482B20", Length = "0x60")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x60004DA")]
  [Address(RVA = "0x487CE0", Offset = "0x4868E0", Length = "0x98")]
  public ProjectileBlackHole()
  {
  }
}
