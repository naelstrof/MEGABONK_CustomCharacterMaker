// Decompiled with JetBrains decompiler
// Type: ProjectilePoisonFlask
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000C8")]
public class ProjectilePoisonFlask : ProjectileBase
{
  [Token(Token = "0x400067F")]
  [FieldOffset(Offset = "0x68")]
  public Rigidbody rb;
  [Token(Token = "0x4000680")]
  [FieldOffset(Offset = "0x70")]
  private float maxProjectileSpeed;
  [Token(Token = "0x4000681")]
  [FieldOffset(Offset = "0x74")]
  public float explosionRadius;
  [Token(Token = "0x4000682")]
  [FieldOffset(Offset = "0x78")]
  public EffectPlayer effect;
  [Token(Token = "0x4000683")]
  [FieldOffset(Offset = "0x80")]
  private Vector3 explosionSizeDefault;

  [Token(Token = "0x6000552")]
  [Address(RVA = "0x4AA770", Offset = "0x4A9370", Length = "0x659")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x6000553")]
  [Address(RVA = "0x4AA3C0", Offset = "0x4A8FC0", Length = "0xD")]
  private float GetSpeed() => 0.0f;

  [Token(Token = "0x6000554")]
  [Address(RVA = "0x4AA400", Offset = "0x4A9000", Length = "0x36C")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000555")]
  [Address(RVA = "0x4AA3D0", Offset = "0x4A8FD0", Length = "0x12")]
  protected override bool HitEnemy(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x6000556")]
  [Address(RVA = "0x4AA3F0", Offset = "0x4A8FF0", Length = "0x7")]
  protected override void HitOther(Collider collider, Vector3 normal)
  {
  }

  [Token(Token = "0x6000557")]
  [Address(RVA = "0x4AA220", Offset = "0x4A8E20", Length = "0x61")]
  private float GetExplosionRadius() => 0.0f;

  [Token(Token = "0x6000558")]
  [Address(RVA = "0x4AA370", Offset = "0x4A8F70", Length = "0x4D")]
  private float GetPoisonDuration() => 0.0f;

  [Token(Token = "0x6000559")]
  [Address(RVA = "0x4AA2F0", Offset = "0x4A8EF0", Length = "0x71")]
  private int GetNumPoisonStacks() => 0;

  [Token(Token = "0x600055A")]
  [Address(RVA = "0x4A9BB0", Offset = "0x4A87B0", Length = "0x660")]
  private void ExplodeFlask()
  {
  }

  [Token(Token = "0x600055B")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x600055C")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x600055D")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x600055E")]
  [Address(RVA = "0x4AA290", Offset = "0x4A8E90", Length = "0x5E")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x600055F")]
  [Address(RVA = "0x4AADD0", Offset = "0x4A99D0", Length = "0x65")]
  public ProjectilePoisonFlask()
  {
  }
}
