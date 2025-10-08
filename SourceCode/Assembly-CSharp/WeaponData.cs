// Decompiled with JetBrains decompiler
// Type: WeaponData
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data;
using Assets.Scripts.Game.Combat;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Inventory__Items__Pickups.Upgrades;
using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Menu.Shop;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Me/Weapon", order = 1)]
[Token(Token = "0x2000228")]
public class WeaponData : UnlockableBase, IUpgradable
{
  [Token(Token = "0x4000F15")]
  [FieldOffset(Offset = "0x50")]
  public EWeapon eWeapon;
  [TextArea]
  [Token(Token = "0x4000F16")]
  [FieldOffset(Offset = "0x58")]
  public string description;
  [Token(Token = "0x4000F17")]
  [FieldOffset(Offset = "0x60")]
  public Texture icon;
  [Token(Token = "0x4000F18")]
  [FieldOffset(Offset = "0x68")]
  public bool onlySpawnWhenCloseEnemies;
  [Token(Token = "0x4000F19")]
  [FieldOffset(Offset = "0x70")]
  public Dictionary<EStat, float> baseStats;
  [Token(Token = "0x4000F1A")]
  [FieldOffset(Offset = "0x78")]
  public float damage;
  [Token(Token = "0x4000F1B")]
  [FieldOffset(Offset = "0x7C")]
  public float knockback;
  [Token(Token = "0x4000F1C")]
  [FieldOffset(Offset = "0x80")]
  public float critChance;
  [Token(Token = "0x4000F1D")]
  [FieldOffset(Offset = "0x84")]
  public EElement element;
  [Token(Token = "0x4000F1E")]
  [FieldOffset(Offset = "0x88")]
  public int projectiles;
  [Token(Token = "0x4000F1F")]
  [FieldOffset(Offset = "0x8C")]
  public int projectileBounces;
  [Token(Token = "0x4000F20")]
  [FieldOffset(Offset = "0x90")]
  public float attackDuration;
  [Token(Token = "0x4000F21")]
  [FieldOffset(Offset = "0x94")]
  public float effectDuration;
  [Token(Token = "0x4000F22")]
  [FieldOffset(Offset = "0x98")]
  public float projectileSpeed;
  [Header("New Quantity and cooldown")]
  [Token(Token = "0x4000F23")]
  [FieldOffset(Offset = "0x9C")]
  public float endCooldown;
  [Token(Token = "0x4000F24")]
  [FieldOffset(Offset = "0xA0")]
  public float burstTime;
  [Token(Token = "0x4000F25")]
  [FieldOffset(Offset = "0xA4")]
  public float minBurstInterval;
  [Header("Behaviour")]
  [Token(Token = "0x4000F26")]
  [FieldOffset(Offset = "0xA8")]
  public bool canBounce;
  [Token(Token = "0x4000F27")]
  [FieldOffset(Offset = "0xAC")]
  public EAmplificationMode amplificationMode;
  [Token(Token = "0x4000F28")]
  [FieldOffset(Offset = "0xB0")]
  public float procCoefficient;
  [Token(Token = "0x4000F29")]
  [FieldOffset(Offset = "0xB4")]
  public bool useVision;
  [Token(Token = "0x4000F2A")]
  [FieldOffset(Offset = "0xB5")]
  public bool hasCrosshair;
  [Token(Token = "0x4000F2B")]
  [FieldOffset(Offset = "0xB8")]
  public float spawnProjectileRange;
  [Token(Token = "0x4000F2C")]
  [FieldOffset(Offset = "0xBC")]
  public bool isAura;
  [Token(Token = "0x4000F2D")]
  [FieldOffset(Offset = "0xC0")]
  public Vector3 spawnOffset;
  [Token(Token = "0x4000F2E")]
  [FieldOffset(Offset = "0xD0")]
  public GameObject attack;
  [Token(Token = "0x4000F2F")]
  [FieldOffset(Offset = "0xD8")]
  public UpgradeData upgradeData;
  [Header("Unlocks")]
  [Token(Token = "0x4000F30")]
  [FieldOffset(Offset = "0xE0")]
  public MyAchievement AchievementRequirement;

  [field: Token(Token = "0x4000F31")]
  [field: FieldOffset(Offset = "0xE8")]
  [Token(Token = "0x17000081")]
  public string damageSourceName { [Token(Token = "0x6000E02"), Address(RVA = "0x53E540", Offset = "0x53D140", Length = "0x8")] get; [Token(Token = "0x6000E03"), Address(RVA = "0x53E550", Offset = "0x53D150", Length = "0x13")] private set; }

  [Token(Token = "0x6000E04")]
  [Address(RVA = "0x53DE90", Offset = "0x53CA90", Length = "0x234")]
  public void Init()
  {
  }

  [Token(Token = "0x6000E05")]
  [Address(RVA = "0x53DE30", Offset = "0x53CA30", Length = "0x29")]
  public string GetUpgradeDescription(int level, List<StatModifier> upgradeOffer, ERarity rarity) => (string) null;

  [Token(Token = "0x6000E06")]
  [Address(RVA = "0x3992F0", Offset = "0x397EF0", Length = "0x5")]
  public override Texture GetIcon() => (Texture) null;

  [Token(Token = "0x6000E07")]
  [Address(RVA = "0x53DDB0", Offset = "0x53C9B0", Length = "0x8")]
  public override MyAchievement GetUnlockRequirement() => (MyAchievement) null;

  [Token(Token = "0x6000E08")]
  [Address(RVA = "0x395320", Offset = "0x393F20", Length = "0x3")]
  public override UnlockableBase GetUnlockableRequirement() => (UnlockableBase) null;

  [Token(Token = "0x6000E09")]
  [Address(RVA = "0x53DDC0", Offset = "0x53C9C0", Length = "0x63")]
  public override string GetUnlockableTypeDisplayString() => (string) null;

  [Token(Token = "0x6000E0A")]
  [Address(RVA = "0x53DCC0", Offset = "0x53C8C0", Length = "0x53")]
  public override string GetInternalName() => (string) null;

  [Token(Token = "0x6000E0B")]
  [Address(RVA = "0x53DD20", Offset = "0x53C920", Length = "0x65")]
  public int GetLevel() => 0;

  [Token(Token = "0x6000E0C")]
  [Address(RVA = "0x53DD90", Offset = "0x53C990", Length = "0x6")]
  public int GetMaxLevel() => 0;

  [Token(Token = "0x6000E0D")]
  [Address(RVA = "0x53DE60", Offset = "0x53CA60", Length = "0x28")]
  public List<StatModifier> GetUpgradeOffer(ERarity rarity) => (List<StatModifier>) null;

  [Token(Token = "0x6000E0E")]
  [Address(RVA = "0x53DC60", Offset = "0x53C860", Length = "0x51")]
  public float GetBaseStat(EStat eStat) => 0.0f;

  [Token(Token = "0x6000E0F")]
  [Address(RVA = "0x53DC20", Offset = "0x53C820", Length = "0x36")]
  public float CalculateTotalDistance(float initialSpeed, float reduction) => 0.0f;

  [Token(Token = "0x6000E10")]
  [Address(RVA = "0x53DDA0", Offset = "0x53C9A0", Length = "0x9")]
  public float GetSpawnProjectileRange() => 0.0f;

  [Token(Token = "0x6000E11")]
  [Address(RVA = "0x53E0D0", Offset = "0x53CCD0", Length = "0x3C2")]
  public override string ToString() => (string) null;

  [Token(Token = "0x6000E12")]
  [Address(RVA = "0x53E4A0", Offset = "0x53D0A0", Length = "0x94")]
  public WeaponData()
  {
  }
}
