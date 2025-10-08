// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles.ProjectileHoming
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Enemies;
using Cpp2ILInjected;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
{
  [Token(Token = "0x2000376")]
  public class ProjectileHoming : ProjectileBase
  {
    [Token(Token = "0x4001783")]
    [FieldOffset(Offset = "0x68")]
    private Enemy enemyTarget;

    [Token(Token = "0x60018C6")]
    [Address(RVA = "0x3F4610", Offset = "0x3F3210", Length = "0x7C")]
    protected override bool TryInit(int projectileIndex) => false;

    [Token(Token = "0x60018C7")]
    [Address(RVA = "0x3F41E0", Offset = "0x3F2DE0", Length = "0x33C")]
    protected override void FindMovementDirection()
    {
    }

    [Token(Token = "0x60018C8")]
    [Address(RVA = "0x3F4600", Offset = "0x3F3200", Length = "0xA")]
    private bool HasBounces() => false;

    [Token(Token = "0x60018C9")]
    [Address(RVA = "0x3F4520", Offset = "0x3F3120", Length = "0xD3")]
    protected override Vector3 GetMovementDirection() => new Vector3();

    [Token(Token = "0x60018CA")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void MyFixedUpdate()
    {
    }

    [Token(Token = "0x60018CB")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void MyUpdate()
    {
    }

    [Token(Token = "0x60018CC")]
    [Address(RVA = "0x3F41D0", Offset = "0x3F2DD0", Length = "0x7")]
    private void DestroySelf()
    {
    }

    [Token(Token = "0x60018CD")]
    [Address(RVA = "0x3F26F0", Offset = "0x3F12F0", Length = "0xE")]
    public ProjectileHoming()
    {
    }
  }
}
