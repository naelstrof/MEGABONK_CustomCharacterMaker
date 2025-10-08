// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Stats.TrackStats
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Inventory__Items__Pickups.Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Weapons.Projectiles;
using Assets.Scripts.Saves___Serialization.Progression.Achievements;
using Cpp2ILInjected;
using Inventory__Items__Pickups.Xp_and_Levels;
using System;
using System.Collections.Generic;

namespace Assets.Scripts.Saves___Serialization.Progression.Stats
{
  [Token(Token = "0x2000331")]
  public static class TrackStats
  {
    [Token(Token = "0x40015B0")]
    public static Action A_PotBroken;
    [Token(Token = "0x40015B1")]
    private static string tornadoDamageSource;
    [Token(Token = "0x40015B2")]
    private static HashSet<EPickup> nonPowerupPickups;
    [Token(Token = "0x40015B3")]
    private static Dictionary<EMyStat, string> statStrings;

    [Token(Token = "0x60016A3")]
    [Address(RVA = "0x3DE630", Offset = "0x3DD230", Length = "0x13E9")]
    public static void Init()
    {
    }

    [Token(Token = "0x60016A4")]
    [Address(RVA = "0x3DD070", Offset = "0x3DBC70", Length = "0x13E9")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x60016A5")]
    [Address(RVA = "0x3DCEF0", Offset = "0x3DBAF0", Length = "0xE6")]
    private static void AddValue(EMyStat stat, int value)
    {
    }

    [Token(Token = "0x60016A6")]
    [Address(RVA = "0x3DCFE0", Offset = "0x3DBBE0", Length = "0x8A")]
    private static void AddValue(string statKey, int value)
    {
    }

    [Token(Token = "0x60016A7")]
    [Address(RVA = "0x3E06B0", Offset = "0x3DF2B0", Length = "0x75")]
    private static void OnGoldChange(PlayerInventory inv, int amount)
    {
    }

    [Token(Token = "0x60016A8")]
    [Address(RVA = "0x3E0CC0", Offset = "0x3DF8C0", Length = "0x56")]
    private static void OnSilverChange(int change)
    {
    }

    [Token(Token = "0x60016A9")]
    [Address(RVA = "0x3DFEE0", Offset = "0x3DEAE0", Length = "0x775")]
    private static void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
    {
    }

    [Token(Token = "0x60016AA")]
    [Address(RVA = "0x3DFE70", Offset = "0x3DEA70", Length = "0x64")]
    private static void OnEnemyDamage(Enemy enemy, DamageContainer dc)
    {
    }

    [Token(Token = "0x60016AB")]
    [Address(RVA = "0x3DFDD0", Offset = "0x3DE9D0", Length = "0x48")]
    private static void OnChestOpened()
    {
    }

    [Token(Token = "0x60016AC")]
    [Address(RVA = "0x3E08E0", Offset = "0x3DF4E0", Length = "0x48")]
    private static void OnItemAdded(EItem eItem)
    {
    }

    [Token(Token = "0x60016AD")]
    [Address(RVA = "0x3E0E50", Offset = "0x3DFA50", Length = "0x4C")]
    private static void OnXpAdded(PlayerXp playerXp, int amount)
    {
    }

    [Token(Token = "0x60016AE")]
    [Address(RVA = "0x3DFA20", Offset = "0x3DE620", Length = "0x30B")]
    private static void OnAchievementUnlocked(MyAchievement ach)
    {
    }

    [Token(Token = "0x60016AF")]
    [Address(RVA = "0x3E0D20", Offset = "0x3DF920", Length = "0x120")]
    private static void OnUnlockPurchased(UnlockableBase unlock)
    {
    }

    [Token(Token = "0x60016B0")]
    [Address(RVA = "0x3E0B20", Offset = "0x3DF720", Length = "0x48")]
    private static void OnProjectileSpawned(ProjectileBase projectileBase)
    {
    }

    [Token(Token = "0x60016B1")]
    [Address(RVA = "0x3E0780", Offset = "0x3DF380", Length = "0x158")]
    private static void OnInteracted(BaseInteractable interactable, bool success)
    {
    }

    [Token(Token = "0x60016B2")]
    [Address(RVA = "0x3E0B70", Offset = "0x3DF770", Length = "0x146")]
    private static void OnShrineCharged(bool notInterrupted)
    {
    }

    [Token(Token = "0x60016B3")]
    [Address(RVA = "0x3DFD30", Offset = "0x3DE930", Length = "0x48")]
    private static void OnChallengeShrineCompleted()
    {
    }

    [Token(Token = "0x60016B4")]
    [Address(RVA = "0x3DFD80", Offset = "0x3DE980", Length = "0x48")]
    private static void OnChestBought()
    {
    }

    [Token(Token = "0x60016B5")]
    [Address(RVA = "0x3E0A30", Offset = "0x3DF630", Length = "0xE1")]
    private static void OnPlayerTakeDamage(PlayerHealth ph, DamageContainer dc, bool brokeShield)
    {
    }

    [Token(Token = "0x60016B6")]
    [Address(RVA = "0x3E0660", Offset = "0x3DF260", Length = "0x48")]
    private static void OnEvade(Enemy attacker)
    {
    }

    [Token(Token = "0x60016B7")]
    [Address(RVA = "0x3E0930", Offset = "0x3DF530", Length = "0x4C")]
    private static void OnLifestealHealing(int amount)
    {
    }

    [Token(Token = "0x60016B8")]
    [Address(RVA = "0x3DFE20", Offset = "0x3DEA20", Length = "0x48")]
    private static void OnDead()
    {
    }

    [Token(Token = "0x60016B9")]
    [Address(RVA = "0x3E0730", Offset = "0x3DF330", Length = "0x48")]
    private static void OnIcecubeFreezeEnemy()
    {
    }

    [Token(Token = "0x60016BA")]
    [Address(RVA = "0x3E0980", Offset = "0x3DF580", Length = "0xAC")]
    private static void OnPickup(Pickup pickup)
    {
    }

    [Token(Token = "0x60016BB")]
    [Address(RVA = "0x3DE4D0", Offset = "0x3DD0D0", Length = "0x158")]
    public static string GetStatString(EMyStat stat) => (string) null;

    [Token(Token = "0x60016BC")]
    [Address(RVA = "0x3DE460", Offset = "0x3DD060", Length = "0x6D")]
    public static string GetCharacterRunsString(ECharacter character) => (string) null;

    [Token(Token = "0x60016BD")]
    [Address(RVA = "0x3E0EA0", Offset = "0x3DFAA0", Length = "0x1A0")]
    static TrackStats()
    {
    }
  }
}
