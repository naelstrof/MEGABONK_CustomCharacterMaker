// Decompiled with JetBrains decompiler
// Type: ProjectileDice
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System;
using UnityEngine;

[Token(Token = "0x20000BE")]
public class ProjectileDice : ProjectileBasic
{
  [Token(Token = "0x4000633")]
  [FieldOffset(Offset = "0x70")]
  public float explosionRadius;
  [Token(Token = "0x4000634")]
  [FieldOffset(Offset = "0x78")]
  public GameObject diceFx;
  [Token(Token = "0x4000635")]
  [FieldOffset(Offset = "0x80")]
  public GameObject diceFx6;
  [Token(Token = "0x4000636")]
  [FieldOffset(Offset = "0x88")]
  public RotateObjectRandomly rotator;
  [Token(Token = "0x4000637")]
  [FieldOffset(Offset = "0x90")]
  private float fxCooldown;
  [Token(Token = "0x4000638")]
  [FieldOffset(Offset = "0x94")]
  private float maxScale;
  [Token(Token = "0x4000639")]
  [FieldOffset(Offset = "0x98")]
  private int diceRoll;
  [Token(Token = "0x400063A")]
  public static Action A_RollSix;
  [Token(Token = "0x400063B")]
  [FieldOffset(Offset = "0xA0")]
  private string explosionFxName;
  [Token(Token = "0x400063C")]
  [FieldOffset(Offset = "0xA8")]
  private string explosionFxName6;

  [Token(Token = "0x60004FB")]
  [Address(RVA = "0x48B300", Offset = "0x489F00", Length = "0x371")]
  protected override bool TryInit(int projectileIndex) => false;

  [Token(Token = "0x60004FC")]
  [Address(RVA = "0x48AA50", Offset = "0x489650", Length = "0xBA")]
  protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

  [Token(Token = "0x60004FD")]
  [Address(RVA = "0x48AB10", Offset = "0x489710", Length = "0x7EF")]
  private void Hitscan(Collider collider)
  {
  }

  [Token(Token = "0x60004FE")]
  [Address(RVA = "0x48B680", Offset = "0x48A280", Length = "0x9D")]
  public ProjectileDice()
  {
  }
}
