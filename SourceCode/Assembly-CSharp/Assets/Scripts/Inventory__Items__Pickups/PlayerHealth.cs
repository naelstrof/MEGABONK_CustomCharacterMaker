// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Inventory__Items__Pickups.PlayerHealth
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Game.Combat;
using Assets.Scripts.Inventory__Items__Pickups.Stats;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.Inventory__Items__Pickups
{
  [Token(Token = "0x200035D")]
  public class PlayerHealth
  {
    [Token(Token = "0x40016E4")]
    public static int maxMaxHp;
    [Token(Token = "0x40016E5")]
    [FieldOffset(Offset = "0x10")]
    public int hp;
    [Token(Token = "0x40016E6")]
    [FieldOffset(Offset = "0x14")]
    public int maxHp;
    [Token(Token = "0x40016E7")]
    [FieldOffset(Offset = "0x18")]
    public float overheal;
    [Token(Token = "0x40016E8")]
    [FieldOffset(Offset = "0x1C")]
    public float maxOverheal;
    [Token(Token = "0x40016E9")]
    [FieldOffset(Offset = "0x20")]
    public float shield;
    [Token(Token = "0x40016EA")]
    [FieldOffset(Offset = "0x24")]
    public float maxShield;
    [Token(Token = "0x40016EB")]
    public static Action<PlayerHealth, DamageContainer, bool> A_TakeDamage;
    [Token(Token = "0x40016EC")]
    public static Action<PlayerHealth, float, bool> A_Heal;
    [Token(Token = "0x40016ED")]
    public static Action<PlayerHealth> A_MaxValuesChanged;
    [Token(Token = "0x40016EE")]
    public static Action<PlayerHealth> A_OverhealUpdate;
    [Token(Token = "0x40016EF")]
    public static Action A_CooldownOver;
    [Token(Token = "0x40016F0")]
    public static Action A_Died;
    [Token(Token = "0x40016F1")]
    public static Action<Enemy> A_Evaded;
    [Token(Token = "0x40016F2")]
    public static Action<DamageContainer, bool> A_CheckStopDamage;
    [Token(Token = "0x40016F3")]
    [FieldOffset(Offset = "0x28")]
    private float baseHp;
    [Token(Token = "0x40016F4")]
    [FieldOffset(Offset = "0x2C")]
    private float baseShield;
    [Token(Token = "0x40016F5")]
    [FieldOffset(Offset = "0x30")]
    private float minFallDamageSpeed;
    [Token(Token = "0x40016F6")]
    [FieldOffset(Offset = "0x34")]
    private float maxFallDamageSpeed;
    [Token(Token = "0x40016F7")]
    [FieldOffset(Offset = "0x38")]
    public float fallDamageTakenAtTime;
    [Token(Token = "0x40016F8")]
    public const string fallDamageSource = "fallDamage";
    [Token(Token = "0x40016F9")]
    public static Action A_StoppedDamage;
    [Token(Token = "0x40016FA")]
    public static Action A_DamagePlayerCalled;
    [Token(Token = "0x40016FB")]
    [FieldOffset(Offset = "0x40")]
    private HashSet<string> ignoreShieldRechargeSources;
    [Token(Token = "0x40016FC")]
    public static string thornsDamageSource;
    [Token(Token = "0x40016FD")]
    [FieldOffset(Offset = "0x48")]
    private float shieldRechargeAtTime;
    [Token(Token = "0x40016FE")]
    [FieldOffset(Offset = "0x4C")]
    private float shieldRegenCooldownTime;
    [Token(Token = "0x40016FF")]
    public const float damageCooldownTime = 0.15f;
    [Token(Token = "0x4001700")]
    public static Action<Enemy, int> A_LifestealProc;
    [Token(Token = "0x4001701")]
    [FieldOffset(Offset = "0x50")]
    private int lifestealHeal;
    [Token(Token = "0x4001702")]
    public static Action<int> A_LifestealHealing;
    [Token(Token = "0x4001703")]
    [FieldOffset(Offset = "0x54")]
    private float leftOverHeal;
    [Token(Token = "0x4001704")]
    public const string healthRegenDamageSource = "HealthRegen";
    [Token(Token = "0x4001705")]
    [FieldOffset(Offset = "0x58")]
    private float nextCheckDeadTime;
    [Token(Token = "0x4001706")]
    [FieldOffset(Offset = "0x5C")]
    private float checkDeadInterval;
    [Token(Token = "0x4001707")]
    [FieldOffset(Offset = "0x60")]
    private float overhealRemovalFractionPerSecond;
    [Token(Token = "0x4001708")]
    [FieldOffset(Offset = "0x64")]
    private float shieldHealingPerTick;
    [Token(Token = "0x4001709")]
    [FieldOffset(Offset = "0x68")]
    private float shieldHealingValue;
    [Token(Token = "0x400170A")]
    [FieldOffset(Offset = "0x6C")]
    private float healingValue;
    [Token(Token = "0x400170B")]
    [FieldOffset(Offset = "0x70")]
    private float healingTime;
    [Token(Token = "0x400170C")]
    [FieldOffset(Offset = "0x74")]
    private float healInterval;
    [Token(Token = "0x400170D")]
    [FieldOffset(Offset = "0x78")]
    private float healPerInterval;
    [Token(Token = "0x400170E")]
    [FieldOffset(Offset = "0x7C")]
    private float healingPerMinute;
    [Token(Token = "0x400170F")]
    [FieldOffset(Offset = "0x80")]
    private float damageCooldown;

    [Token(Token = "0x60017F1")]
    [Address(RVA = "0x3EB690", Offset = "0x3EA290", Length = "0x824")]
    public PlayerHealth(PlayerStatsNew playerStats)
    {
    }

    [Token(Token = "0x60017F2")]
    [Address(RVA = "0x3E9A50", Offset = "0x3E8650", Length = "0x55C")]
    public void OnDestroy()
    {
    }

    [Token(Token = "0x60017F3")]
    [Address(RVA = "0x3EA160", Offset = "0x3E8D60", Length = "0x62")]
    private void OnPickup(Pickup pickup)
    {
    }

    [Token(Token = "0x60017F4")]
    [Address(RVA = "0x3EA4C0", Offset = "0x3E90C0", Length = "0xBC")]
    private void OnStatUpdate(EStat stat)
    {
    }

    [Token(Token = "0x60017F5")]
    [Address(RVA = "0x3EA150", Offset = "0x3E8D50", Length = "0x7")]
    private void OnLevelUp(int lvl)
    {
    }

    [Token(Token = "0x60017F6")]
    [Address(RVA = "0x3EB220", Offset = "0x3E9E20", Length = "0xAA")]
    private void UpdateRegenValues(float forceValue = 0.0f)
    {
    }

    [Token(Token = "0x60017F7")]
    [Address(RVA = "0x3EA1D0", Offset = "0x3E8DD0", Length = "0x2E7")]
    private void OnPlayerLanded(float speed)
    {
    }

    [Token(Token = "0x60017F8")]
    [Address(RVA = "0x3EAFB0", Offset = "0x3E9BB0", Length = "0x269")]
    private void UpdateMaxValues()
    {
    }

    [Token(Token = "0x60017F9")]
    [Address(RVA = "0x3E8EA0", Offset = "0x3E7AA0", Length = "0x75")]
    public void DamagePlayer(Enemy enemy, Vector3 direction, DcFlags flags = DcFlags.None)
    {
    }

    [Token(Token = "0x60017FA")]
    [Address(RVA = "0x3E8CE0", Offset = "0x3E78E0", Length = "0x1B6")]
    public void DamagePlayerExternal(
      float damage,
      float knockback,
      Vector3 direction,
      bool ignoreShield = false,
      string damageSource = "Enemy",
      DcFlags flags = DcFlags.None,
      EDamageEffect damageEffect = EDamageEffect.None,
      Enemy enemy = null)
    {
    }

    [Token(Token = "0x60017FB")]
    [Address(RVA = "0x3E8F20", Offset = "0x3E7B20", Length = "0x507")]
    private void Damage(DamageContainer dc, bool ignoreShield)
    {
    }

    [Token(Token = "0x60017FC")]
    [Address(RVA = "0x3E8730", Offset = "0x3E7330", Length = "0x72")]
    private void CheckDamageCooldown(DamageContainer dc)
    {
    }

    [Token(Token = "0x60017FD")]
    [Address(RVA = "0x3E8880", Offset = "0x3E7480", Length = "0x9F")]
    private void CheckShieldRecharge(DamageContainer dc)
    {
    }

    [Token(Token = "0x60017FE")]
    [Address(RVA = "0x3E9A30", Offset = "0x3E8630", Length = "0x15")]
    public void KillPlayer()
    {
    }

    [Token(Token = "0x60017FF")]
    [Address(RVA = "0x3E8920", Offset = "0x3E7520", Length = "0x399")]
    public bool CheckStopDamage(DamageContainer dc, bool ignoreShield) => false;

    [Token(Token = "0x6001800")]
    [Address(RVA = "0x3EB2D0", Offset = "0x3E9ED0", Length = "0x2B5")]
    private void UseAegis(DamageContainer dc, Color color, string text = "Block")
    {
    }

    [Token(Token = "0x6001801")]
    [Address(RVA = "0x3EB5C0", Offset = "0x3EA1C0", Length = "0x44")]
    public bool WillDamageKill(DamageContainer dc, bool ignoreShield) => false;

    [Token(Token = "0x6001802")]
    [Address(RVA = "0x3EB590", Offset = "0x3EA190", Length = "0x2D")]
    public bool WillDamageKill(float damage, bool ignoreShield) => false;

    [Token(Token = "0x6001803")]
    [Address(RVA = "0x3E9430", Offset = "0x3E8030", Length = "0x2A7")]
    private void Evade(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001804")]
    [Address(RVA = "0x3EA600", Offset = "0x3E9200", Length = "0x28F")]
    public void Retaliate(DamageContainer dc)
    {
    }

    [Token(Token = "0x6001805")]
    [Address(RVA = "0x3E9720", Offset = "0x3E8320", Length = "0x1B")]
    private float GetDamageCooldown() => 0.0f;

    [Token(Token = "0x6001806")]
    [Address(RVA = "0x3E9FB0", Offset = "0x3E8BB0", Length = "0x195")]
    private void OnEnemyDamaged(Enemy enemy, DamageContainer dc)
    {
    }

    [Token(Token = "0x6001807")]
    [Address(RVA = "0x3EADE0", Offset = "0x3E99E0", Length = "0x165")]
    private void TryLifestealHit(Enemy enemy, DamageContainer dc)
    {
    }

    [Token(Token = "0x6001808")]
    [Address(RVA = "0x3E85C0", Offset = "0x3E71C0", Length = "0x94")]
    private void ApplyLifesteal()
    {
    }

    [Token(Token = "0x6001809")]
    [Address(RVA = "0x3E9760", Offset = "0x3E8360", Length = "0x2BE")]
    public int Heal(float amount, bool allowOverheal = true) => 0;

    [Token(Token = "0x600180A")]
    [Address(RVA = "0x3EA890", Offset = "0x3E9490", Length = "0x54D")]
    public void Tick()
    {
    }

    [Token(Token = "0x600180B")]
    [Address(RVA = "0x3E87B0", Offset = "0x3E73B0", Length = "0xC6")]
    private void CheckDead()
    {
    }

    [Token(Token = "0x600180C")]
    [Address(RVA = "0x3EAF50", Offset = "0x3E9B50", Length = "0x5F")]
    private void UpdateHealthRegen()
    {
    }

    [Token(Token = "0x600180D")]
    [Address(RVA = "0x3EA580", Offset = "0x3E9180", Length = "0x76")]
    public void PlayerDied()
    {
    }

    [Token(Token = "0x600180E")]
    [Address(RVA = "0x3E9A20", Offset = "0x3E8620", Length = "0x8")]
    public bool IsDead() => false;

    [Token(Token = "0x600180F")]
    [Address(RVA = "0x3E86A0", Offset = "0x3E72A0", Length = "0x88")]
    public bool CanTakeDamage() => false;

    [Token(Token = "0x6001810")]
    [Address(RVA = "0x3E96E0", Offset = "0x3E82E0", Length = "0x12")]
    public int GetCombinedHp() => 0;

    [Token(Token = "0x6001811")]
    [Address(RVA = "0x3E9700", Offset = "0x3E8300", Length = "0x12")]
    public int GetCombinedMaxHp() => 0;

    [Token(Token = "0x6001812")]
    [Address(RVA = "0x3E9740", Offset = "0x3E8340", Length = "0x15")]
    public float GetHpRatio() => 0.0f;

    [Token(Token = "0x6001813")]
    [Address(RVA = "0x3E8CC0", Offset = "0x3E78C0", Length = "0x13")]
    public bool DamageCooldown() => false;

    [Token(Token = "0x6001814")]
    [Address(RVA = "0x3E8660", Offset = "0x3E7260", Length = "0x13")]
    public bool CanHeal() => false;

    [Token(Token = "0x6001815")]
    [Address(RVA = "0x3E8680", Offset = "0x3E7280", Length = "0x18")]
    private bool CanLifesteal() => false;

    [Token(Token = "0x6001816")]
    [Address(RVA = "0x3EB610", Offset = "0x3EA210", Length = "0x7B")]
    static PlayerHealth()
    {
    }
  }
}
