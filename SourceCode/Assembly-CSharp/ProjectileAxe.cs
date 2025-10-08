// Decompiled with JetBrains decompiler
// Type: ProjectileAxe
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000B8")]
public class ProjectileAxe : ProjectileBase
{
  [Token(Token = "0x40005F9")]
  [FieldOffset(Offset = "0x68")]
  public float collisionCooldown;
  [Token(Token = "0x40005FA")]
  [FieldOffset(Offset = "0x70")]
  public TrailRenderer trailRenderer;
  [Token(Token = "0x40005FB")]
  [FieldOffset(Offset = "0x78")]
  private float forwardOffset;
  [Token(Token = "0x40005FC")]
  [FieldOffset(Offset = "0x7C")]
  private float upOffset;
  [Token(Token = "0x40005FD")]
  [FieldOffset(Offset = "0x80")]
  public RandomSfx sfx;
  [Token(Token = "0x40005FE")]
  [FieldOffset(Offset = "0x88")]
  public GameObject sfxLoop;
  [Token(Token = "0x40005FF")]
  [FieldOffset(Offset = "0x90")]
  private Vector3 pushDir;
  [Token(Token = "0x4000600")]
  [FieldOffset(Offset = "0x9C")]
  private Vector3 desiredPosition;
  [Token(Token = "0x4000601")]
  [FieldOffset(Offset = "0xA8")]
  private Vector3 startPosition;
  [Token(Token = "0x4000602")]
  [FieldOffset(Offset = "0xB4")]
  private float moveTime;
  [Token(Token = "0x4000603")]
  [FieldOffset(Offset = "0xB8")]
  private float nextCheckDamageTime;
  [Token(Token = "0x4000604")]
  [FieldOffset(Offset = "0xBC")]
  private float moveTimer;

  [Token(Token = "0x60004B5")]
  [Address(RVA = "0x484E20", Offset = "0x483A20", Length = "0x66F")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x60004B6")]
  [Address(RVA = "0x484BE0", Offset = "0x4837E0", Length = "0x87")]
  private float GetAngle(int projectileIndex, int maxIndex) => 0.0f;

  [Token(Token = "0x60004B7")]
  [Address(RVA = "0x483E90", Offset = "0x482A90", Length = "0x47")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x60004B8")]
  [Address(RVA = "0x484C70", Offset = "0x483870", Length = "0x7")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x60004B9")]
  [Address(RVA = "0x484630", Offset = "0x483230", Length = "0x5AE")]
  private void CheckDamage()
  {
  }

  [Token(Token = "0x60004BA")]
  [Address(RVA = "0x484C80", Offset = "0x483880", Length = "0x19F")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x60004BB")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x60004BC")]
  [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
  private float GetRadius() => 0.0f;

  [Token(Token = "0x60004BD")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x60004BE")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x60004BF")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x60004C0")]
  [Address(RVA = "0x483F20", Offset = "0x482B20", Length = "0x60")]
  private void OnDrawGizmosSelected()
  {
  }

  [Token(Token = "0x60004C1")]
  [Address(RVA = "0x485490", Offset = "0x484090", Length = "0x18")]
  public ProjectileAxe()
  {
  }
}
