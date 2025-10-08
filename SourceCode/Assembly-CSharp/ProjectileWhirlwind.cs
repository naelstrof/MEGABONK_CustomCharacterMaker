// Decompiled with JetBrains decompiler
// Type: ProjectileWhirlwind
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[Token(Token = "0x20000CC")]
public class ProjectileWhirlwind : ProjectileBase
{
  [Token(Token = "0x4000691")]
  [FieldOffset(Offset = "0x68")]
  public Rigidbody rb;
  [Token(Token = "0x4000692")]
  [FieldOffset(Offset = "0x70")]
  private Dictionary<Collider, float> enemyHitCooldowns;
  [Token(Token = "0x4000693")]
  [FieldOffset(Offset = "0x78")]
  private float hitCooldown;
  [Token(Token = "0x4000694")]
  [FieldOffset(Offset = "0x7C")]
  private Vector3 startDirection;
  [Token(Token = "0x4000695")]
  [FieldOffset(Offset = "0x88")]
  private float maxSpeed;
  [Token(Token = "0x4000696")]
  [FieldOffset(Offset = "0x8C")]
  private float speed;
  [Token(Token = "0x4000697")]
  [FieldOffset(Offset = "0x90")]
  private float nextCheckDamageTime;

  [Token(Token = "0x6000586")]
  [Address(RVA = "0x4AE590", Offset = "0x4AD190", Length = "0x356")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x6000587")]
  [Address(RVA = "0x4ADD30", Offset = "0x4AC930", Length = "0x16")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x6000588")]
  [Address(RVA = "0x4ADBA0", Offset = "0x4AC7A0", Length = "0x188")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x6000589")]
  [Address(RVA = "0x4ADD50", Offset = "0x4AC950", Length = "0xCB")]
  private Vector3 GetRaycastPosition() => new Vector3();

  [Token(Token = "0x600058A")]
  [Address(RVA = "0x4AE1F0", Offset = "0x4ACDF0", Length = "0x391")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x600058B")]
  [Address(RVA = "0x4ADBA0", Offset = "0x4AC7A0", Length = "0x188")]
  private void CheckRadiusDamage()
  {
  }

  [Token(Token = "0x600058C")]
  [Address(RVA = "0x4ADB00", Offset = "0x4AC700", Length = "0x92")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x600058D")]
  [Address(RVA = "0x4ADE20", Offset = "0x4ACA20", Length = "0x3CA")]
  private bool HitEnemy(Collider collider) => false;

  [Token(Token = "0x600058E")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x600058F")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x6000590")]
  [Address(RVA = "0x4AE8F0", Offset = "0x4AD4F0", Length = "0x7E")]
  public ProjectileWhirlwind()
  {
  }
}
