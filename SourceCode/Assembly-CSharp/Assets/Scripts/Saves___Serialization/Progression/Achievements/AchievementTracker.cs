// Decompiled with JetBrains decompiler
// Type: Assets.Scripts.Saves___Serialization.Progression.Achievements.AchievementTracker
// Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F9EBB483-F0AD-4292-B8BF-A0A2361B82C2
// Assembly location: F:\Games\Megabonk\BepInEx\dummy\Assembly-CSharp.dll

using Assets.Scripts._Data.Tomes;
using Assets.Scripts.Actors;
using Assets.Scripts.Actors.Enemies;
using Assets.Scripts.Inventory__Items__Pickups;
using Assets.Scripts.Inventory__Items__Pickups.Items;
using Assets.Scripts.Inventory__Items__Pickups.Weapons;
using Assets.Scripts.Menu.Shop;
using Cpp2ILInjected;

namespace Assets.Scripts.Saves___Serialization.Progression.Achievements
{
  [Token(Token = "0x2000336")]
  public static class AchievementTracker
  {
    [Token(Token = "0x40015D2")]
    private static float baseMovementSpeed;
    [Token(Token = "0x40015D3")]
    private static float noDamageTimer;
    [Token(Token = "0x40015D4")]
    private static bool hasTakenDamageThisRun;
    [Token(Token = "0x40015D5")]
    private static bool hasDealtDamageThisRun;
    [Token(Token = "0x40015D6")]
    private static int consecutiveIceCrystalCooks;
    [Token(Token = "0x40015D7")]
    private static int consecutiveMoldyCheeseCooks;
    [Token(Token = "0x40015D8")]
    private static int runChestsBought;
    [Token(Token = "0x40015D9")]
    private static bool hasSpawnedLuckTomeQuest;
    [Token(Token = "0x40015DA")]
    private static string aegisDamageSource;
    [Token(Token = "0x40015DB")]
    private static int chargedShrines;
    [Token(Token = "0x40015DC")]
    private static int chargedShrinesNoInterruptions;
    [Token(Token = "0x40015DD")]
    private static int totalChargeShrines;
    [Token(Token = "0x40015DE")]
    private static int numBoomboxes;

    [Token(Token = "0x60016EF")]
    [Address(RVA = "0x3C2AC0", Offset = "0x3C16C0", Length = "0x17A5")]
    public static void Init()
    {
    }

    [Token(Token = "0x60016F0")]
    [Address(RVA = "0x3C13F0", Offset = "0x3BFFF0", Length = "0x16C5")]
    public static void Cleanup()
    {
    }

    [Token(Token = "0x60016F1")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private static void OnFinalSwarmStart()
    {
    }

    [Token(Token = "0x60016F2")]
    [Address(RVA = "0x3C5A70", Offset = "0x3C4670", Length = "0xB6")]
    private static void OnRunStarted()
    {
    }

    [Token(Token = "0x60016F3")]
    [Address(RVA = "0x3C6900", Offset = "0x3C5500", Length = "0x192")]
    private static void OnStageStarted()
    {
    }

    [Token(Token = "0x60016F4")]
    [Address(RVA = "0x3C5670", Offset = "0x3C4270", Length = "0x96")]
    private static void OnPLayerInventoryInited(PlayerInventory inv)
    {
    }

    [Token(Token = "0x60016F5")]
    [Address(RVA = "0x3C6AA0", Offset = "0x3C56A0", Length = "0x1DC")]
    private static void OnStatUpdate(EStat stat)
    {
    }

    [Token(Token = "0x60016F6")]
    [Address(RVA = "0x3C6C80", Offset = "0x3C5880", Length = "0x452")]
    private static void OnTick()
    {
    }

    [Token(Token = "0x60016F7")]
    [Address(RVA = "0x3C4390", Offset = "0x3C2F90", Length = "0x615")]
    private static void OnEnemyDied(Enemy enemy, DamageContainer deathSource)
    {
    }

    [Token(Token = "0x60016F8")]
    [Address(RVA = "0x3C5D10", Offset = "0x3C4910", Length = "0xBE2")]
    private static void OnStageBossDefeated(bool isOpeningPortal)
    {
    }

    [Token(Token = "0x60016F9")]
    [Address(RVA = "0x3C42D0", Offset = "0x3C2ED0", Length = "0x64")]
    private static void OnDamageTaken(PlayerHealth ph, DamageContainer dc, bool brokeShield)
    {
    }

    [Token(Token = "0x60016FA")]
    [Address(RVA = "0x3C4340", Offset = "0x3C2F40", Length = "0x4F")]
    private static void OnEnemyDamaged(Enemy arg1, DamageContainer arg2)
    {
    }

    [Token(Token = "0x60016FB")]
    [Address(RVA = "0x3C50F0", Offset = "0x3C3CF0", Length = "0x336")]
    private static void OnLevelUp(int level)
    {
    }

    [Token(Token = "0x60016FC")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private static void OnChestBought()
    {
    }

    [Token(Token = "0x60016FD")]
    [Address(RVA = "0x3C5B30", Offset = "0x3C4730", Length = "0x1D7")]
    private static void OnShrineCharged(bool noChargeInterruption)
    {
    }

    [Token(Token = "0x60016FE")]
    [Address(RVA = "0x3C4270", Offset = "0x3C2E70", Length = "0x53")]
    private static void OnChargeShrineSpawned()
    {
    }

    [Token(Token = "0x60016FF")]
    [Address(RVA = "0x3C5430", Offset = "0x3C4030", Length = "0x234")]
    private static void OnMicrowaveUsed(EItem eItem)
    {
    }

    [Token(Token = "0x6001700")]
    [Address(RVA = "0x3C8130", Offset = "0x3C6D30", Length = "0x16F")]
    private static void OnWeaponAddedOrUpgraded(WeaponBase weapon)
    {
    }

    [Token(Token = "0x6001701")]
    [Address(RVA = "0x3C70E0", Offset = "0x3C5CE0", Length = "0xE25")]
    private static void OnTomeAddedOrUpgraded(ETome eTome, EStat stat)
    {
    }

    [Token(Token = "0x6001702")]
    [Address(RVA = "0x3C4FD0", Offset = "0x3C3BD0", Length = "0x11C")]
    private static void OnItemAdded(EItem item)
    {
    }

    [Token(Token = "0x6001703")]
    [Address(RVA = "0x339280", Offset = "0x337E80", Length = "0x3")]
    private static void OnPickupTriggered(Pickup pickup)
    {
    }

    [Token(Token = "0x6001704")]
    [Address(RVA = "0x3C5710", Offset = "0x3C4310", Length = "0x139")]
    private static void OnPotBroken()
    {
    }

    [Token(Token = "0x6001705")]
    [Address(RVA = "0x3C49B0", Offset = "0x3C35B0", Length = "0x61E")]
    private static void OnInteracted(BaseInteractable interactable, bool success)
    {
    }

    [Token(Token = "0x6001706")]
    [Address(RVA = "0x3C7F10", Offset = "0x3C6B10", Length = "0x212")]
    private static void OnUnlock(MyAchievement achUnlocked)
    {
    }

    [Token(Token = "0x6001707")]
    [Address(RVA = "0x3C5850", Offset = "0x3C4450", Length = "0x21E")]
    private static void OnPurchased(UnlockableBase unlockable)
    {
    }

    [Token(Token = "0x6001708")]
    [Address(RVA = "0x3C82A0", Offset = "0x3C6EA0", Length = "0x98")]
    static AchievementTracker()
    {
    }
  }
}
