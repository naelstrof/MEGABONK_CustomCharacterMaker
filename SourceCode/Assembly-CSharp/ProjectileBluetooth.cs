// Decompiled with JetBrains decompiler
// Type: ProjectileBluetooth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using UnityEngine;

[Token(Token = "0x20000BC")]
public class ProjectileBluetooth : ProjectileBase
{
  [Token(Token = "0x4000624")]
  [FieldOffset(Offset = "0x68")]
  protected Enemy target;
  [Token(Token = "0x4000625")]
  [FieldOffset(Offset = "0x70")]
  private GameObject lastTarget;

  [Token(Token = "0x60004E3")]
  [Address(RVA = "0x488FF0", Offset = "0x487BF0", Length = "0x37E")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x60004E4")]
  [Address(RVA = "0x4884A0", Offset = "0x4870A0", Length = "0x293")]
  protected override void FindMovementDirection()
  {
  }

  [Token(Token = "0x60004E5")]
  [Address(RVA = "0x488740", Offset = "0x487340", Length = "0x151")]
  protected override Vector3 GetMovementDirection() => new Vector3();

  [Token(Token = "0x60004E6")]
  [Address(RVA = "0x488BE0", Offset = "0x4877E0", Length = "0x40C")]
  protected override void StepMovement()
  {
  }

  [Token(Token = "0x60004E7")]
  [Address(RVA = "0x488920", Offset = "0x487520", Length = "0x2B6")]
  private void HitTarget()
  {
  }

  [Token(Token = "0x60004E8")]
  [Address(RVA = "0x4888A0", Offset = "0x4874A0", Length = "0x75")]
  protected override bool HitEnemy(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x60004E9")]
  [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x60004EA")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void CheckSpawnCollision()
  {
  }

  [Token(Token = "0x60004EB")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void HitOther(Collider collider, Vector3 normal)
  {
  }

  [Token(Token = "0x60004EC")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyUpdate()
  {
  }

  [Token(Token = "0x60004ED")]
  [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
  protected override void MyFixedUpdate()
  {
  }

  [Token(Token = "0x60004EE")]
  [Address(RVA = "0x484620", Offset = "0x483220", Length = "0x7")]
  public ProjectileBluetooth()
  {
  }
}
