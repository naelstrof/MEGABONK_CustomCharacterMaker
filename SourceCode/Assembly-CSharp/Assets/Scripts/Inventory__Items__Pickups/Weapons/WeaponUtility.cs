// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.Weapons.WeaponUtility
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups.Weapons
{
  [Token(Token = "0x200036B")]
  public static class WeaponUtility
  {
    [Token(Token = "0x400174F")]
    public static Action<DamageContainer> A_CreateDamageContainerPreAttack;
    [Token(Token = "0x4001750")]
    private static StatComponents itemModifier;
    [Token(Token = "0x4001751")]
    private static DamageContainer weaponDc;
    [Token(Token = "0x4001752")]
    private static DamageContainer otherDc;
    [Token(Token = "0x4001753")]
    private static List<int> availableIndexes;

    [Token(Token = "0x600186D")]
    [Address(RVA = "0x3FE870", Offset = "0x3FD470", Length = "0x4AA")]
    public static DamageContainer GetDamageContainer(
      WeaponBase weaponBase,
      ProjectileBase projectile,
      Enemy enemy,
      Vector3 direction,
      float forceDamage = -1f)
    {
      return (DamageContainer) null;
    }

    [Token(Token = "0x600186E")]
    [Address(RVA = "0x3FED20", Offset = "0x3FD920", Length = "0x26E")]
    public static DamageContainer GetDamageContainer(
      DamageContainer recycleDc,
      float baseDamage,
      float procCoefficient,
      string damageSourceName,
      Vector3 direction,
      Enemy enemy)
    {
      return (DamageContainer) null;
    }

    [Token(Token = "0x600186F")]
    [Address(RVA = "0x4002B0", Offset = "0x3FEEB0", Length = "0xCE")]
    private static float GetWeaponDamage(WeaponBase weaponBase, float forceDamage) => 0.0f;

    [Token(Token = "0x6001870")]
    [Address(RVA = "0x3FF480", Offset = "0x3FE080", Length = "0x1D5")]
    private static float GetNewDamage(float baseDamage, StatComponents itemModifierStatComponents) => 0.0f;

    [Token(Token = "0x6001871")]
    [Address(RVA = "0x3FF080", Offset = "0x3FDC80", Length = "0x8A")]
    public static float GetDamage(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x6001872")]
    [Address(RVA = "0x3FF110", Offset = "0x3FDD10", Length = "0x24")]
    private static float GetDamage(float damage) => 0.0f;

    [Token(Token = "0x6001873")]
    [Address(RVA = "0x3FF140", Offset = "0x3FDD40", Length = "0x4B")]
    private static float GetDcCritMultiplier(float critChance, DamageContainer dc) => 0.0f;

    [Token(Token = "0x6001874")]
    [Address(RVA = "0x3FFB00", Offset = "0x3FE700", Length = "0x68D")]
    public static Enemy GetRandomEnemyInRange(
      Vector3 position,
      float range,
      bool tryAimForward = false,
      GameObject exceptObject = null)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x6001875")]
    [Address(RVA = "0x3FF750", Offset = "0x3FE350", Length = "0x3A0")]
    public static Enemy GetRandomEnemyInRadius(
      Vector3 position,
      float radius,
      GameObject exceptObject = null)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x6001876")]
    [Address(RVA = "0x3FF220", Offset = "0x3FDE20", Length = "0xAE")]
    public static Collider[] GetEnemiesInRadius(Vector3 position, float radius) => (Collider[]) null;

    [Token(Token = "0x6001877")]
    [Address(RVA = "0x3FDF90", Offset = "0x3FCB90", Length = "0x5B0")]
    public static Enemy ConecastEnemyInVision(Vector3 position, float range, bool useRandom) => (Enemy) null;

    [Token(Token = "0x6001878")]
    [Address(RVA = "0x3FF2D0", Offset = "0x3FDED0", Length = "0x10C")]
    public static Enemy GetIndex0EnemyInRange(
      Vector3 position,
      WeaponData weaponData,
      GameObject exceptObject = null)
    {
      return (Enemy) null;
    }

    [Token(Token = "0x6001879")]
    [Address(RVA = "0x3FE5F0", Offset = "0x3FD1F0", Length = "0x6A")]
    public static float GetAttackSizeMultiplier(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x600187A")]
    [Address(RVA = "0x3FE550", Offset = "0x3FD150", Length = "0x9F")]
    public static int GetAttackQuantity(WeaponBase weaponBase) => 0;

    [Token(Token = "0x600187B")]
    [Address(RVA = "0x3FF660", Offset = "0x3FE260", Length = "0x70")]
    public static int GetProjectileBounces(WeaponBase weaponBase) => 0;

    [Token(Token = "0x600187C")]
    [Address(RVA = "0x3FF6E0", Offset = "0x3FE2E0", Length = "0x6A")]
    public static float GetProjectileSpeed(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x600187D")]
    [Address(RVA = "0x3FF190", Offset = "0x3FDD90", Length = "0x8C")]
    public static float GetDuration(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x600187E")]
    [Address(RVA = "0x3FE660", Offset = "0x3FD260", Length = "0x103")]
    public static float GetBurstInterval(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x600187F")]
    [Address(RVA = "0x400190", Offset = "0x3FED90", Length = "0x11E")]
    public static float GetWeaponCooldown(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x6001880")]
    [Address(RVA = "0x3FE770", Offset = "0x3FD370", Length = "0x74")]
    public static float GetCritChance(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x6001881")]
    [Address(RVA = "0x3FE7F0", Offset = "0x3FD3F0", Length = "0x74")]
    public static float GetCritDamageMultiplier(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x6001882")]
    [Address(RVA = "0x3FF3E0", Offset = "0x3FDFE0", Length = "0x6A")]
    public static float GetKnockback(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x6001883")]
    [Address(RVA = "0x3FEF90", Offset = "0x3FDB90", Length = "0xEF")]
    public static float GetDamageProjectile(ProjectileBase projectile) => 0.0f;

    [Token(Token = "0x6001884")]
    [Address(RVA = "0x400380", Offset = "0x3FEF80", Length = "0x6A")]
    public static float GetWeaponRange(WeaponBase weaponBase) => 0.0f;

    [Token(Token = "0x6001885")]
    [Address(RVA = "0x3FF470", Offset = "0x3FE070", Length = "0x6")]
    public static int GetMaxProjectilesPoolSize(EWeapon weapon) => 0;

    [Token(Token = "0x6001886")]
    [Address(RVA = "0x3FF460", Offset = "0x3FE060", Length = "0x6")]
    public static int GetMaxProjectileHitsPoolSize(EWeapon weapon) => 0;

    [Token(Token = "0x6001887")]
    [Address(RVA = "0x3FF460", Offset = "0x3FE060", Length = "0x6")]
    public static int GetMaxProjectileDonePoolSize(EWeapon weapon) => 0;

    [Token(Token = "0x6001888")]
    [Address(RVA = "0x3FF450", Offset = "0x3FE050", Length = "0x6")]
    public static int GetMaxAttacksPoolSize(EWeapon weapon) => 0;

    [Token(Token = "0x6001889")]
    [Address(RVA = "0x400660", Offset = "0x3FF260", Length = "0x27E")]
    public static void WeaponAttack(WeaponBase weapon)
    {
    }

    [Token(Token = "0x600188A")]
    [Address(RVA = "0x4003F0", Offset = "0x3FEFF0", Length = "0x268")]
    public static void LightningStrike(
      Enemy enemy,
      int bounces,
      DamageContainer dc,
      float bounceRange,
      float bounceProcCoefficient)
    {
    }

    [Token(Token = "0x600188B")]
    [Address(RVA = "0x3FD990", Offset = "0x3FC590", Length = "0x5FB")]
    private static void ChainLightning(
      Enemy initialEnemy,
      int numBounces,
      float bounceRange,
      DamageContainer sourceDc,
      float bounceProcCoefficient)
    {
    }

    [Token(Token = "0x600188C")]
    [Address(RVA = "0x4008E0", Offset = "0x3FF4E0", Length = "0x192")]
    static WeaponUtility()
    {
    }
  }
}
