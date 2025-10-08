// Decompiled with JetBrains decompiler
// Type: ProjectileLightningBolt
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000C4")]
public class ProjectileLightningBolt : ProjectileBase
{
  [Token(Token = "0x6000532")]
  [Address(RVA = "0x4A7DA0", Offset = "0x4A69A0", Length = "0x2BD")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x6000533")]
  [Address(RVA = "0x487D80", Offset = "0x486980", Length = "0x4A")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x6000534")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x6000535")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x6000536")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x6000537")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x6000538")]
  [Address(RVA = "0x484620", Offset = "0x483220", Length = "0x7")]
  public ProjectileLightningBolt()
  {
  }
}
