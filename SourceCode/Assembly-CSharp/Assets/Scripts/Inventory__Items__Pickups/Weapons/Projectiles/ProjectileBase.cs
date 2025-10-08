// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles.ProjectileBase
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Inventory__Items__Pickups.Weapons.Attacks;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles
{
  [Token(Token = "0x2000372")]
  public abstract class ProjectileBase : MonoBehaviour
  {
    [Token(Token = "0x400176B")]
    [FieldOffset(Offset = "0x20")]
    public WeaponBase weaponBase;
    [Token(Token = "0x400176C")]
    [FieldOffset(Offset = "0x28")]
    protected WeaponAttack weaponAttack;
    [Token(Token = "0x400176D")]
    [FieldOffset(Offset = "0x30")]
    public float projectileRadius;
    [Token(Token = "0x400176E")]
    [FieldOffset(Offset = "0x34")]
    private float baseProjectileRadius;
    [Token(Token = "0x400176F")]
    [FieldOffset(Offset = "0x38")]
    public Vector3 direction;
    [Token(Token = "0x4001770")]
    [FieldOffset(Offset = "0x44")]
    public int bounces;
    [Token(Token = "0x4001771")]
    [FieldOffset(Offset = "0x48")]
    public int maxBounces;
    [Token(Token = "0x4001772")]
    [FieldOffset(Offset = "0x4C")]
    protected bool timedOut;
    [Token(Token = "0x4001773")]
    [FieldOffset(Offset = "0x50")]
    protected float expirationTime;
    [Token(Token = "0x4001774")]
    [FieldOffset(Offset = "0x54")]
    protected float projectileSpeed;
    [Token(Token = "0x4001775")]
    [FieldOffset(Offset = "0x58")]
    protected Collider lastHitEnemy;
    [Token(Token = "0x4001776")]
    [FieldOffset(Offset = "0x60")]
    protected HashSet<Collider> hitEnemies;

    [Token(Token = "0x60018A0")]
    [Address(RVA = "0x3F1F80", Offset = "0x3F0B80", Length = "0x33C")]
    public void Set(WeaponBase weaponBase, WeaponAttack weaponAttack, int projectileIndex)
    {
    }

    [Token(Token = "0x60018A1")]
    [Address(RVA = "0x3F1440", Offset = "0x3F0040", Length = "0xC1")]
    protected float GetDuration() => 0.0f;

    [Token(Token = "0x60018A2")]
    protected abstract bool TryInit(int projectileIndex);

    [Token(Token = "0x60018A3")]
    [Address(RVA = "0x3F1330", Offset = "0x3EFF30", Length = "0x108")]
    private void FixedUpdate()
    {
    }

    [Token(Token = "0x60018A4")]
    [Address(RVA = "0x3F1120", Offset = "0x3EFD20", Length = "0x162")]
    protected virtual void CheckSpawnCollision()
    {
    }

    [Token(Token = "0x60018A5")]
    protected abstract Vector3 GetMovementDirection();

    [Token(Token = "0x60018A6")]
    [Address(RVA = "0x3F22C0", Offset = "0x3F0EC0", Length = "0x3BE")]
    protected virtual void StepMovement()
    {
    }

    [Token(Token = "0x60018A7")]
    [Address(RVA = "0x3F2680", Offset = "0x3F1280", Length = "0x6F")]
    private void Update()
    {
    }

    [Token(Token = "0x60018A8")]
    [Address(RVA = "0x3F1290", Offset = "0x3EFE90", Length = "0x97")]
    private void CheckTimeout()
    {
    }

    [Token(Token = "0x60018A9")]
    [Address(RVA = "0x3F1E80", Offset = "0x3F0A80", Length = "0xF8")]
    protected void ProjectileDone()
    {
    }

    [Token(Token = "0x60018AA")]
    protected abstract void MyFixedUpdate();

    [Token(Token = "0x60018AB")]
    protected abstract void MyUpdate();

    [Token(Token = "0x60018AC")]
    [Address(RVA = "0x3F0FC0", Offset = "0x3EFBC0", Length = "0x153")]
    protected virtual bool CheckCollision(Collider collider, Vector3 normal) => false;

    [Token(Token = "0x60018AD")]
    [Address(RVA = "0x3F1510", Offset = "0x3F0110", Length = "0x3FB")]
    protected virtual bool HitEnemy(Collider collider, Vector3 normal) => false;

    [Token(Token = "0x60018AE")]
    protected abstract void FindMovementDirection();

    [Token(Token = "0x60018AF")]
    [Address(RVA = "0x3F1910", Offset = "0x3F0510", Length = "0x56B")]
    protected virtual void HitOther(Collider collider, Vector3 normal)
    {
    }

    [Token(Token = "0x60018B0")]
    [Address(RVA = "0x3F26F0", Offset = "0x3F12F0", Length = "0xE")]
    protected ProjectileBase()
    {
    }
  }
}
