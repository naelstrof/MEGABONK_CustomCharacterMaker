// Decompiled with JetBrains decompiler
// Type: ProjectileArrow
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B7")]
public class ProjectileArrow : ProjectileBase
{
  [Token(Token = "0x40005F0")]
  [FieldOffset(Offset = "0x68")]
  public TrailRenderer trailRenderer;
  [Token(Token = "0x40005F1")]
  [FieldOffset(Offset = "0x70")]
  private float upOffset;
  [Token(Token = "0x40005F2")]
  [FieldOffset(Offset = "0x78")]
  public RandomSfx startSfx;
  [Token(Token = "0x40005F3")]
  [FieldOffset(Offset = "0x80")]
  public GameObject sfxLoop;
  [Token(Token = "0x40005F4")]
  [FieldOffset(Offset = "0x88")]
  private Vector3 pushDir;
  [Token(Token = "0x40005F5")]
  [FieldOffset(Offset = "0x94")]
  private float trailStartWidth;
  [Token(Token = "0x40005F6")]
  private static Vector3 baseDir;
  [Token(Token = "0x40005F7")]
  [FieldOffset(Offset = "0x98")]
  private float speedReduction;
  [Token(Token = "0x40005F8")]
  [FieldOffset(Offset = "0x9C")]
  private float nextCheckDamageTime;

  [Token(Token = "0x60004AB")]
  [Address(RVA = "0x483F90", Offset = "0x482B90", Length = "0x684")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x60004AC")]
  [Address(RVA = "0x483DF0", Offset = "0x4829F0", Length = "0x93")]
  private float GetAngle(int projectileIndex, int maxIndex) => 0.0f;

  [Token(Token = "0x60004AD")]
  [Address(RVA = "0x483E90", Offset = "0x482A90", Length = "0x47")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x60004AE")]
  [Address(RVA = "0x483EE0", Offset = "0x482AE0", Length = "0x3A")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x60004AF")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  private void CheckDamage()
  {
  }

  [Token(Token = "0x60004B0")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x60004B1")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x60004B2")]
  [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x60004B3")]
  [Address(RVA = "0x483F20", Offset = "0x482B20", Length = "0x60")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x60004B4")]
  [Address(RVA = "0x484620", Offset = "0x483220", Length = "0x7")]
  public ProjectileArrow()
  {
  }
}
