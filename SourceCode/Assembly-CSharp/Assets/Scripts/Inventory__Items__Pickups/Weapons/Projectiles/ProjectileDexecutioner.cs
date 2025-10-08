// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles.ProjectileDexecutioner
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
{
  [Token(Token = "0x2000374")]
  public class ProjectileDexecutioner : ProjectileBase
  {
    [Token(Token = "0x4001778")]
    [FieldOffset(Offset = "0x68")]
    public Vector3 colliderOffset;
    [Token(Token = "0x4001779")]
    [FieldOffset(Offset = "0x74")]
    public float testMultiplier;
    [Token(Token = "0x400177A")]
    [FieldOffset(Offset = "0x78")]
    public float projectileDistance;
    [Token(Token = "0x400177B")]
    [FieldOffset(Offset = "0x7C")]
    private float forwardOffset;
    [Token(Token = "0x400177C")]
    [FieldOffset(Offset = "0x80")]
    private float upOffset;
    [Token(Token = "0x400177D")]
    [FieldOffset(Offset = "0x84")]
    public Vector3 attackDir;
    [Token(Token = "0x400177E")]
    [FieldOffset(Offset = "0x90")]
    public float executionChance;
    [Token(Token = "0x400177F")]
    [FieldOffset(Offset = "0x98")]
    private List<ProjectileDexecutioner.MeleeHit> effectHits;
    [Token(Token = "0x4001780")]
    [FieldOffset(Offset = "0xA0")]
    private bool useAudio;

    [Token(Token = "0x60018B9")]
    [Address(RVA = "0x3F3B10", Offset = "0x3F2710", Length = "0x5BE")]
    protected override bool TryInit(int projectileIndex) => false;

    [Token(Token = "0x60018BA")]
    [Address(RVA = "0x3F3790", Offset = "0x3F2390", Length = "0x19")]
    protected override Vector3 GetMovementDirection() => new Vector3();

    [Token(Token = "0x60018BB")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void MyFixedUpdate()
    {
    }

    [Token(Token = "0x60018BC")]
    [Address(RVA = "0x3F37C0", Offset = "0x3F23C0", Length = "0x1CB")]
    protected override void MyUpdate()
    {
    }

    [Token(Token = "0x60018BD")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void FindMovementDirection()
    {
    }

    [Token(Token = "0x60018BE")]
    [Address(RVA = "0x3F2F90", Offset = "0x3F1B90", Length = "0x7F9")]
    public void CheckZone(WeaponBase weaponBase, float radius, GameObject hitEffect = null)
    {
    }

    [Token(Token = "0x60018BF")]
    [Address(RVA = "0x3F3990", Offset = "0x3F2590", Length = "0x17F")]
    private void SpawnEffect()
    {
    }

    [Token(Token = "0x60018C0")]
    [Address(RVA = "0x3F37B0", Offset = "0x3F23B0", Length = "0x6")]
    private float GetRadius() => 0.0f;

    [Token(Token = "0x60018C1")]
    [Address(RVA = "0x3D1AA0", Offset = "0x3D06A0", Length = "0x3")]
    protected override bool CheckCollision(Collider collider, Vector3 normal) => false;

    [Token(Token = "0x60018C2")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void StepMovement()
    {
    }

    [Token(Token = "0x60018C3")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    protected override void CheckSpawnCollision()
    {
    }

    [Token(Token = "0x60018C4")]
    [Address(RVA = "0x3F40D0", Offset = "0x3F2CD0", Length = "0xFE")]
    public ProjectileDexecutioner()
    {
    }

    [Token(Token = "0x2000375")]
    private class MeleeHit
    {
      [Token(Token = "0x4001781")]
      [FieldOffset(Offset = "0x10")]
      public Vector3 pos;
      [Token(Token = "0x4001782")]
      [FieldOffset(Offset = "0x1C")]
      public Vector3 dir;

      [Token(Token = "0x60018C5")]
      [Address(RVA = "0x3E8570", Offset = "0x3E7170", Length = "0x4D")]
      public MeleeHit(Vector3 pos, Vector3 dir)
      {
      }
    }
  }
}
