// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.Attacks.WeaponAttack
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors.Player;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System;
using System.Collections;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons.Attacks
{
  [Token(Token = "0x2000378")]
  public class WeaponAttack : MonoBehaviour
  {
    [Token(Token = "0x4001784")]
    [FieldOffset(Offset = "0x20")]
    public GameObject prefabProjectile;
    [Token(Token = "0x4001785")]
    [FieldOffset(Offset = "0x28")]
    public GameObject prefabMuzzle;
    [Token(Token = "0x4001786")]
    [FieldOffset(Offset = "0x30")]
    public GameObject prefabHit;
    [Token(Token = "0x4001787")]
    [FieldOffset(Offset = "0x38")]
    public WeaponBase weaponBase;
    [Token(Token = "0x4001788")]
    [FieldOffset(Offset = "0x40")]
    protected MyPlayer player;
    [Token(Token = "0x4001789")]
    [FieldOffset(Offset = "0x48")]
    private bool attackDone;
    [Token(Token = "0x400178A")]
    [FieldOffset(Offset = "0x4C")]
    public float projectileSizeMultiplier;
    [Token(Token = "0x400178B")]
    [FieldOffset(Offset = "0x50")]
    public Action A_SpawnedProjectile;
    [Token(Token = "0x400178C")]
    public static Action<ProjectileBase> A_SpawnedProjectileSuccessfully;
    [Token(Token = "0x400178D")]
    [FieldOffset(Offset = "0x58")]
    private float expirationTime;
    [Token(Token = "0x400178E")]
    [FieldOffset(Offset = "0x60")]
    private EnemyScanContainer lastCheckSphere;
    [Token(Token = "0x400178F")]
    [FieldOffset(Offset = "0x68")]
    public bool lastWasSkip;
    [Token(Token = "0x4001790")]
    [FieldOffset(Offset = "0x6C")]
    private float muzzleCooldown;
    [Token(Token = "0x4001791")]
    [FieldOffset(Offset = "0x70")]
    private AttackMuzzle muzzle;

    [Token(Token = "0x60018D1")]
    [Address(RVA = "0x3F9880", Offset = "0x3F8480", Length = "0x95")]
    public void SetAttack(WeaponBase weaponBase, MyPlayer player)
    {
    }

    [Token(Token = "0x60018D2")]
    [Address(RVA = "0x3F9ED0", Offset = "0x3F8AD0", Length = "0x67")]
    private IEnumerator StartAttack() => (IEnumerator) null;

    [Token(Token = "0x60018D3")]
    [Address(RVA = "0x3F9920", Offset = "0x3F8520", Length = "0x5AC")]
    protected virtual void SpawnProjectile(int projectileIndex)
    {
    }

    [Token(Token = "0x60018D4")]
    [Address(RVA = "0x3F95C0", Offset = "0x3F81C0", Length = "0xBD")]
    public float GetSize() => 0.0f;

    [Token(Token = "0x60018D5")]
    [Address(RVA = "0x3F9680", Offset = "0x3F8280", Length = "0xB0")]
    public void ProjectileDone(ProjectileBase projectile)
    {
    }

    [Token(Token = "0x60018D6")]
    [Address(RVA = "0x3F9740", Offset = "0x3F8340", Length = "0x13C")]
    public void ProjectileHit(Vector3 hitPos, Vector3 moveDir, bool hitEnemy, bool useSfx)
    {
    }

    [Token(Token = "0x60018D7")]
    [Address(RVA = "0x3F9F40", Offset = "0x3F8B40", Length = "0x579")]
    public void SuccessfullySpawnedProjectile(ProjectileBase projectile)
    {
    }

    [Token(Token = "0x60018D8")]
    [Address(RVA = "0x3FA4C0", Offset = "0x3F90C0", Length = "0x148")]
    private void Update()
    {
    }

    [Token(Token = "0x60018D9")]
    [Address(RVA = "0x3F9390", Offset = "0x3F7F90", Length = "0xE6")]
    private void AttackTimeout()
    {
    }

    [Token(Token = "0x60018DA")]
    [Address(RVA = "0x3F9480", Offset = "0x3F8080", Length = "0xEA")]
    private Vector3 GetProjectilePosition() => new Vector3();

    [Token(Token = "0x60018DB")]
    [Address(RVA = "0x3F9570", Offset = "0x3F8170", Length = "0x45")]
    private Quaternion GetProjectileRotation() => new Quaternion();

    [Token(Token = "0x60018DC")]
    [Address(RVA = "0x3FA610", Offset = "0x3F9210", Length = "0xD1")]
    public WeaponAttack()
    {
    }
  }
}
