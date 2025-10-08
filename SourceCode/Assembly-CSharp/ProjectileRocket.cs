// Decompiled with JetBrains decompiler
// Type: ProjectileRocket
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000C9")]
public class ProjectileRocket : ProjectileBase
{
  [Token(Token = "0x4000684")]
  [FieldOffset(Offset = "0x68")]
  public Rocket rocket;
  [Token(Token = "0x4000685")]
  [FieldOffset(Offset = "0x70")]
  private string damageSource;

  [Token(Token = "0x6000560")]
  [Address(RVA = "0x4AAE40", Offset = "0x4A9A40", Length = "0xF6")]
  private void Awake()
  {
  }

  [Token(Token = "0x6000561")]
  [Address(RVA = "0x4AB040", Offset = "0x4A9C40", Length = "0x1FB")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x6000562")]
  [Address(RVA = "0x487D80", Offset = "0x486980", Length = "0x4A")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x6000563")]
  [Address(RVA = "0x4AAF40", Offset = "0x4A9B40", Length = "0xF6")]
  private void OnDestroy()
  {
  }

  [Token(Token = "0x6000564")]
  [Address(RVA = "0x3F41D0", Offset = "0x3F2DD0", Length = "0x7")]
  private void OnRocketDone()
  {
  }

  [Token(Token = "0x6000565")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x6000566")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x6000567")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x6000568")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000569")]
  [Address(RVA = "0x4AB240", Offset = "0x4A9E40", Length = "0x6E")]
  public ProjectileRocket()
  {
  }
}
