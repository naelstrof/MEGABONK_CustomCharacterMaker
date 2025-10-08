// Decompiled with JetBrains decompiler
// Type: ProjectileBloodMagic
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000BB")]
public class ProjectileBloodMagic : ProjectileBase
{
  [Token(Token = "0x4000623")]
  [FieldOffset(Offset = "0x68")]
  private Enemy target;

  [Token(Token = "0x60004DB")]
  [Address(RVA = "0x487EA0", Offset = "0x486AA0", Length = "0x5FA")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x60004DC")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x60004DD")]
  [Address(RVA = "0x487D80", Offset = "0x486980", Length = "0x4A")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x60004DE")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x60004DF")]
  [Address(RVA = "0x487DD0", Offset = "0x4869D0", Length = "0xC0")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x60004E0")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x60004E1")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x60004E2")]
  [Address(RVA = "0x484620", Offset = "0x483220", Length = "0x7")]
  public ProjectileBloodMagic()
  {
  }
}
